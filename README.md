# EventAuthApi – ASP.NET Core Web API met JWT-authenticatie

Deze REST API biedt endpoints voor:
- Gebruikersregistratie & -login (met **Identity Framework**)
- JWT-generatie voor beveiligde toegang
- Eventbeheer (indien uitgebreid)

---

## Vereisten

- [.NET 8.0 SDK](https://dotnet.microsoft.com/)
- Visual Studio 2022+
- SQLite als lokale databank

---

## Installatie

1. Clone deze repo:
   ```bash
   git clone <repo-url>
   ```

2. Open de oplossing `EventAuthApi.sln` in Visual Studio.

3. Controleer de `appsettings.json`-sectie voor JWT-configuratie:

    ```json
    "Jwt": {
      "Key": "JOUW_SUPER_GEHEIME_SLEUTEL_VAN_MIN_32_BYTES",
      "Issuer": "EventAuthApi",
      "Audience": "MauiFixTest",
      "DurationInMinutes": "60"
    }
    ```

4. Voer EF Core migraties uit:

    ```bash
    dotnet ef database update
    ```

5. Start het project met `Ctrl + F5`.

6. Open Swagger UI op:  
   [https://localhost:7179/swagger](https://localhost:7179/swagger)

---

## JWT Authenticatie Flow

| Actie                      | Endpoint               | Uitleg                        |
|---------------------------|------------------------|-------------------------------|
| **Registeren**            | `POST /api/auth/register` | Nieuwe gebruiker aanmaken    |
| **Login**                 | `POST /api/auth/login`    | JWT-token ontvangen           |

Gebruik deze JWT-token in je mobiele app (MauiFixTest) voor beveiligde communicatie met de API.

---

## Structuur van het project

```
EventAuthApi/
│
├── Controllers/
│   └── AuthController.cs        # Login & registratie
│
├── Data/
│   └── AppDbContext.cs         # EF Core context + Identity setup
│
├── Models/
│   ├── LoginDto.cs
│   └── RegisterDto.cs
│
├── Program.cs                 # JWT config + Middleware
└── appsettings.json
```

---

## AI-geassisteerde hulp

De volgende delen zijn geschreven met hulp van GitHub Copilot of ChatGPT, maar **verder aangepast en getest**:

- JWT-configuratie in `Program.cs`
- De logica in `AuthController.cs`
- Identity setup en token-aanmaak
- Validatie en foutafhandeling

---

## Licentie

> Dit project is ontwikkeld voor **onderwijsdoeleinden**. Geen distributie of commercieel gebruik zonder toestemming.
