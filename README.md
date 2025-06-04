## EventAuthApi – ASP.NET Core Web API met JWT-authenticatie

Deze REST API biedt endpoints voor:
- Gebruikersregistratie & -login (met **Identity Framework**)
- JWT-generatie voor beveiligde toegang
- Eventbeheer (indien uitgebreid)

## Vereisten

- .NET 8 of 9 SDK
- Visual Studio 2022+
- SQLite als lokale databank

## Installatie

1. Clone deze repo
2. Open `EventAuthApi.sln`
3. Controleer de `appsettings.json`:

"Jwt": {
  "Key": "JOUW_SUPER_GEHEIME_SLEUTEL_VAN_MIN_32_BYTES",
  "Issuer": "EventAuthApi",
  "Audience": "MauiFixTest",
  "DurationInMinutes": "60"
}
Voer EF Core migraties uit:

dotnet ef database update
Start het project (Ctrl + F5)

Gebruik Swagger UI op https://localhost:xxxx/swagger om endpoints te testen

JWT Auth Flow
POST /api/auth/register → maakt nieuwe user

POST /api/auth/login → retourneert JWT-token

Gebruik dit token in je mobiele app voor beveiligde communicatie.

Structuur
Controllers/

AuthController.cs: login en registratie

Data/

AppDbContext.cs: SQLite context met Identity

Models/

LoginDto.cs, RegisterDto.cs

AI-geassisteerde hulp
Volgende zaken werden deels gegenereerd met GitHub Copilot of ChatGPT:

JWT-configuratie in Program.cs

AuthController logica

Setup van Identity Framework

Licentie
Onderwijsdoeleinden. Geen distributie zonder toestemming.

