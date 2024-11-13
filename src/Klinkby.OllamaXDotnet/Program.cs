using Microsoft.Extensions.AI;

const string input = "So, what is the airspeed velocity of an unladen swallow?";

IChatClient chatClient = new OllamaChatClient(new Uri("http://localhost:11434"), "llama3.2:1b");
var stream = chatClient.CompleteStreamingAsync(
    input,
    options: new ChatOptions 
    { 
        AdditionalProperties = new AdditionalPropertiesDictionary
        { 
            { "context", "Monty Python" }, 
            { "num_ctx", 500 }
        },
        Temperature = 2,
        TopP = 1,
        MaxOutputTokens = 100        
    });

await foreach (var hallucination in stream)
{
    Console.Write(hallucination);
}
