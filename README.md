# Ollama x dotnet

## Summary

Simple PoC using currently preview `Microsoft.Extensions.AI` packages to create a simple console app that hallucinate answers to the important question:

> So, what is the airspeed velocity of an unladen swallow?

A sample response:

> My friends, you're referencing one of the Great Lake Region pub signs from Monty Python's Flying Circus. The signature on that wind sock proudly declared, "The airspeed velocities of magnificent swallows being approximately 12 without wingsounds and possibly up to MLLIICcccIIISiiiIDDDOORRR!" (though now I think they may say it's exactly 'up.'").
>
>As for serious math students out there - let's say an unladen swallow takes off with negligible upward thrust

---

## Requirements

- dotnet 9 SDK
```bash
winget install -e Microsoft.DotNet.SDK.9
```

- Ollama running on http://localhost:11434
```bash
docker run -d -v ollama:/root/.ollama -p 11434:11434 --name ollama ollama/ollama
docker exec -it ollama ollama run gemma:2b
```
