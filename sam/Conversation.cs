using OpenAI.GPT3.Managers;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.GPT3.ObjectModels;
using OpenAI.GPT3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sam
{
    internal class Conversation
    {
        private readonly OpenAIService sdk;
        private readonly List<string> systemPersonality;
        
        // create a list to hold chat messages
        public List<ChatMessage> chatHistory = new List<ChatMessage>();

        public Conversation(string apiKey, List<string> systemPersonality)
        {
            this.sdk = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });
            this.systemPersonality = systemPersonality;
        }

        public async Task<string> StartConversation(string userInput)
        {
            string convResponse = "Sorry, I don't understand.";
            List<ChatMessage> convMessages = new List<ChatMessage> { };

            //System personality
            foreach (var per in systemPersonality)
            {
                ChatMessage chatMessage = new ChatMessage("user", per);
                convMessages.Add(chatMessage);

            }

            //Add conversation history
            foreach (var chis in chatHistory)
            {
                convMessages.Add(chis);

            }


            ChatMessage cmessage = new ChatMessage("user", userInput);
            convMessages.Add(cmessage);

            chatHistory.Add(cmessage);

            var completionResult = await sdk.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = convMessages,
                Model = Models.ChatGpt3_5Turbo
            });

            if (completionResult.Successful)
            {
                convResponse = completionResult.Choices.First().Message.Content;

                ChatMessage npcmessage = new ChatMessage("assistant", convResponse);
                chatHistory.Add(npcmessage);

                return convResponse;
            }

            return convResponse;
        }

    }
}

