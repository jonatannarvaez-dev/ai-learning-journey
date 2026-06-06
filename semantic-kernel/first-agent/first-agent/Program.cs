using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

var builder = Kernel.CreateBuilder();
builder.AddOllamaChatCompletion("qwen2.5-coder:7b", new Uri("http://localhost:11434"));
var kernel = builder.Build();
var chat = kernel.GetRequiredService<IChatCompletionService>();

var history = new ChatHistory("""
    You are Butcher, a personal software development assistant.
    You are concise, direct, and helpful. You assist with coding tasks and technical questions.
    """);

Console.WriteLine("Butcher online.");

while (true)
{
    Console.Write("\n[You] ");
    var input = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(input)) continue;
    if (input.ToLower() == "exit") break;

    history.AddUserMessage(input);

    Console.Write("\n[Butcher] ");
    var response = new System.Text.StringBuilder();

    await foreach (var chunk in chat.GetStreamingChatMessageContentsAsync(history, kernel: kernel))
    {
        if (chunk.Content is not null)
        {
            Console.Write(chunk.Content);
            response.Append(chunk.Content);
        }
    }

    Console.WriteLine();
    history.AddAssistantMessage(response.ToString());
}
