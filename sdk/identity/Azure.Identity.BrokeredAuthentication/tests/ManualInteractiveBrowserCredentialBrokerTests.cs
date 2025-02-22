﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using NUnit.Framework;

namespace Azure.Identity.BrokeredAuthentication.Tests
{
    public class ManualInteractiveBrowserCredentialBrokerTests
    {
        [Test]
        [Ignore("This test is an integration test which can only be run with user interaction")]
        public async Task AuthenticateWithBrokerAsync()
        {
            // to fully manually verify the InteractiveBrowserCredential this test should be run both authenticating with a
            // school / organization account as well as a personal live account, i.e. a @outlook.com, @live.com, or @hotmail.com
            var cred = new InteractiveBrowserCredential(new InteractiveBrowserCredentialBrokerOptions());

            AccessToken token = await cred.GetTokenAsync(new TokenRequestContext(new string[] { "https://vault.azure.net/.default" })).ConfigureAwait(false);

            Assert.NotNull(token.Token);
        }
    }
}
