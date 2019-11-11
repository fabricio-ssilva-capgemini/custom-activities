﻿using Ayehu.Sdk.ActivityCreation.Interfaces;
using Ayehu.Sdk.ActivityCreation.Extension;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Admin.Directory.directory_v1;
using Google.Apis.Admin.Directory.directory_v1.Data;
using System.Collections.Generic;

namespace ActivitiesAyehu
{
    public class GSuiteAddUser : IActivity
    {
        public string ServiceAccountEmail, PrivateKey, UserId;

        public string GivenName, FamilyName, PrimaryEmail, SecondaryEmail, Password;

        public ICustomActivityResult Execute()
        {
            var result = AddUser();

            return this.GenerateActivityResult(result);
        }

        private string AddUser()
        {
            ServiceAccountCredential credential = new ServiceAccountCredential(
               new ServiceAccountCredential.Initializer(ServiceAccountEmail)
               {
                   User = UserId,
                   Scopes = new[] { DirectoryService.Scope.AdminDirectoryUser, DirectoryService.Scope.AdminDirectoryGroup }
               }.FromPrivateKey(PrivateKey));

            var cs = new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "GSuiteAddUser"
            };

            var t = new DirectoryService(cs);

            var request = t.Users.Insert(new User
            {
                PrimaryEmail = PrimaryEmail,
                Password = Password,
                Name = new UserName { GivenName = GivenName, FamilyName = FamilyName },
                Emails = new List<UserEmail> { new UserEmail { Primary = true, Address = SecondaryEmail } }
            });

            request.Execute();

            return "Success";
        }
    }
}
