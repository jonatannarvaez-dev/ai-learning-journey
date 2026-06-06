# first-agent — AI Development Agent

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![.NET 10](https://img.shields.io/badge/.NET-10-512BD4?style=flat&logo=dotnet&logoColor=white)
![Semantic Kernel](https://img.shields.io/badge/Semantic%20Kernel-1.76-blue?style=flat)
![Ollama](https://img.shields.io/badge/Ollama-local-black?style=flat)
![License MIT](https://img.shields.io/badge/license-MIT-green?style=flat)

> A personal AI-powered software development assistant built with Microsoft Semantic Kernel and a local LLM via Ollama.

## Why I built this
I wanted to explore how AI agents work from the ground up — not just call an API, but understand the orchestration layer. first-agent runs entirely on a local LLM (no API key, no cloud, no cost), which makes it a great sandbox for experimenting with Semantic Kernel, function calling, and agent design patterns.

## Features
- Conversational AI chat loop with real-time streaming
- Local LLM (no API key, no cost, full privacy)
- Extensible plugin architecture (Semantic Kernel)

## Tech stack
| Layer         | Technology                         |
|---------------|------------------------------------|
| Language      | C# / .NET 10                       |
| AI framework  | Microsoft Semantic Kernel 1.76     |
| LLM           | Ollama + qwen2.5-coder:7b (local)  |

## Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- [Ollama](https://ollama.com) running locally at `http://localhost:11434`
- Model pulled: `ollama pull qwen2.5-coder:7b`

## Project structure
```
first-agent/
├── first-agent/
│   ├── Program.cs              # Entry point and chat loop
│   └── first-agent.csproj      # Project file and dependencies
└── first-agent.slnx            # Solution file
```

## Getting started
```bash
dotnet run --project first-agent
```

## Author
Jona — .NET developer exploring AI agent development
