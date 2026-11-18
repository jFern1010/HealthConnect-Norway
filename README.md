# HealthConnect Norway

A healthcare interoperability portfolio project that simulates patient information
exchange between a hospital system and a municipal healthcare system, using HL7 FHIR.

## Why I built this

I have worked in the healthcare sector and have seen first-hand how important it is
that patient information flows safely between hospitals and municipal services.
This project combines that domain experience with backend development and HL7 FHIR.

## Status

 In progress, following a 12-week learning roadmap.

- [x] M1: C# fundamentals and Patient model
- [ ] M2: First working Patient API (ASP.NET Core)
- [ ] M5: First FHIR resources
- [ ] M12: Portfolio-ready release v1.0

## Planned tech stack

C#, ASP.NET Core Web API, Entity Framework Core, PostgreSQL, HL7 FHIR R4 (Firely .NET SDK),
xUnit, Docker and GitHub Actions.

## Repository structure

- `learning/HealthConnectStarter`: console app for C# fundamentals (Patient model, collections, loops)

## Run the starter app

Requires the .NET 10 SDK.

```
cd learning/HealthConnectStarter
dotnet run
```

## Disclaimer

This is a learning and portfolio project. It uses **synthetic data only** and is not certified,
production-connected, or integrated with Norsk helsenett, HelseID, or any real healthcare system.