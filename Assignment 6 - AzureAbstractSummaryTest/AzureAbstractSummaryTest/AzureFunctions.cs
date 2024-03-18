/*
 * Filename:    AzureFunctions.cs
 * Author:      Colin Eade
 * Date:        December 11, 2023
 *
 * This code is based on work originally created by Microsoft and Jose Harriaga.
 * https://learn.microsoft.com/en-ca/azure/ai-services/language-service/summarization/quickstart?tabs=document-summarization%2Cwindows&pivots=programming-language-csharp
 * https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/textanalytics/Azure.AI.TextAnalytics/samples/Sample12_AbstractiveSummarize.md
 * 
 * * Modifications made:
 * - Overhauled the code to change it from a quickstart sample that runs in the console to a standalone
 *   function that takes an external string input
 */

using Azure;
using Azure.AI.TextAnalytics;

namespace AzureAbstractSummaryTest
{
    /// <summary>
    /// Handles Azure AI text analytics functions
    /// </summary>
    internal class AzureFunctions
    {
        // Credentials
        // NOTE: These are only hardcoded for demonstrative purposes
        static string languageKey = "52d0022a2d024bd09c6f582b924af98b";
        static string languageEndpoint = "https://azuretestanalyticstest.cognitiveservices.azure.com/";

        // Credential and endpoint objects to create a client to interact with Azure services
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential(languageKey);
        private static readonly Uri endpoint = new Uri(languageEndpoint);

        /// <summary>
        /// Uses Azure AI Text Analytics services to summarize a string given to it
        /// </summary>
        /// <param name="inputText">The text to be summarized</param>
        /// <returns>An abstractive summary of the text passed through it</returns>
        /// <exception cref="Exception">Raises an exception upon an execution error</exception>
        public static async Task<string> SummarizeText(string inputText)
        {
            // If there is no text to process, throw an exception
            if (string.IsNullOrWhiteSpace(inputText) || inputText == "Enter text to summarize")
            {
                throw new Exception("Please input some text to be summarized.");
            }

            // Create a client object to interact with Azure Cognitive Services
            TextAnalyticsClient client = new TextAnalyticsClient(endpoint, credentials);

            // Get the text passed to the function
            var batchInput = new List<string>
            {
                inputText
            };

            // Perform the text analysis operation
            // Returns a collection
            AbstractiveSummarizeOperation operation = client.AbstractiveSummarize(WaitUntil.Completed, batchInput);

            // View the operation results
            await foreach (AbstractiveSummarizeResultCollection results in operation.Value)
            {
                // Grab our result from the collection
                // Will only be one because only one object in the batchInput list was passed through
                foreach (AbstractiveSummarizeResult result in results)
                {
                    // Raise exception if there is an error in the result
                    if (result.HasError)
                    {
                        throw new Exception($"Error {result.Error.ErrorCode}\n\n{result.Error.Message}");
                    }

                    // Result is valid
                    // return the summary
                    foreach (AbstractiveSummary summary in result.Summaries)
                    {
                        return summary.Text;
                    }
                }
            }

            // Operation failed if we get to here
            throw new Exception("Summarization operation failed to complete.");

        }
    }      
}
