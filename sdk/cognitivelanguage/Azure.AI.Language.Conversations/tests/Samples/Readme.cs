﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using Azure.Core.TestFramework;

namespace Azure.AI.Language.Conversations.Tests.Samples
{
    public partial class ConversationAnalysisClientSamples : ConversationAnalysisTestBase<ConversationAnalysisClient>
    {
        public void CreateConversationAnalysisClient()
        {
            #region Snippet:ConversationAnalysisClient_Create
            Uri endpoint = new Uri("https://myaccount.api.cognitive.microsoft.com");
            AzureKeyCredential credential = new AzureKeyCredential("{api-key}");

            ConversationAnalysisClient client = new ConversationAnalysisClient(endpoint, credential);
            #endregion
        }

        [RecordedTest]
        [SyncOnly]
        public void BadArgument()
        {
            ConversationAnalysisClient client = Client;

            #region Snippet:ConversationAnalysisClient_BadRequest
            try
            {
                ConversationsProject conversationsProject = new ConversationsProject("invalid-project", "production");
                Response<AnalyzeConversationTaskResult> response = client.AnalyzeConversation(
                    "Send an email to Carol about the tomorrow's demo",
                    conversationsProject);
            }
            catch (RequestFailedException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            #endregion
        }
    }
}
