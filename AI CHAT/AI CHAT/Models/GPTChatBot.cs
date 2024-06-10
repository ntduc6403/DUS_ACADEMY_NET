using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AI_CHAT.Models
{
    using System;
    using System.Threading.Tasks;
    using OpenAI;

    namespace YourNamespace.ChatBot
    {
        public class GPTChatBot
        {
            private readonly OpenAIClient client;

            public GPTChatBot(string apiKey)
            {
                client = new OpenAIClient(apiKey);
            }

            public async Task<string> GetResponse(string question)
            {
                try
                {
                    var completion = await client.Completions.CreateCompletionAsync(
                        model: "text-davinci-003",
                        prompt: question,
                        maxTokens: 150
                    );

                    return completion.Data.Choices[0].Text.Trim();
                }
                catch (Exception ex)
                {
                    return $"Error: {ex.Message}";
                }
            }
        }
    }

}