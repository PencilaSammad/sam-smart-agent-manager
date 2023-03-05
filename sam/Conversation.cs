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
    // This is a class for a conversation, which holds the SDK instance and a list of system personalities.

    internal class Conversation
    {
        private readonly OpenAIService sdk;
        private readonly List<string> systemPersonality;

        // Create a list to hold chat messages
        public List<ChatMessage> chatHistory = new List<ChatMessage>();

        // Constructor for Conversation class that takes an API key and a list of system personalities as input.
        public Conversation(string apiKey, List<string> systemPersonality)
        {
            this.sdk = new OpenAIService(new OpenAiOptions()
            {
                ApiKey = apiKey
            });
            this.systemPersonality = systemPersonality;
        }

        // Method to start a conversation by taking a user's input and returning a response.
        public async Task<string> StartConversation(string userInput)
        {
            string convResponse = "Sorry, I don't understand.";
            List<ChatMessage> convMessages = new List<ChatMessage> { };

            // Add system personality to conversation
            foreach (var per in systemPersonality)
            {
                ChatMessage chatMessage = new ChatMessage("user", per);
                convMessages.Add(chatMessage);
            }

            // Add conversation history to conversation
            foreach (var chis in chatHistory)
            {
                convMessages.Add(chis);
            }

            ChatMessage cmessage = new ChatMessage("user", userInput);
            convMessages.Add(cmessage);

            chatHistory.Add(cmessage);

            // Create a completion result using the SDK and the conversation messages
            var completionResult = await sdk.ChatCompletion.CreateCompletion(new ChatCompletionCreateRequest
            {
                Messages = convMessages,
                Model = Models.ChatGpt3_5Turbo
            });

            // If successful, return the response and add it to the chat history
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

