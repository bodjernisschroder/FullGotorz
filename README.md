## Gotorz - Exam Project Team 7 (DMOoF24)

Welcome to **Gotorz**, our final exam project that combines a Blazor Web App and a supporting Web API architecture for a complete travel package booking experience!

![.NET](https://img.shields.io/badge/.NET-8.0-blueviolet)
![Blazor](https://img.shields.io/badge/Blazor-Server-green)
![Entity Framework](https://img.shields.io/badge/Entity_Framework-Core-blue)
![SQLite](https://img.shields.io/badge/SQLite-DB-lightgrey)
![Project Type](https://img.shields.io/badge/Project-Exam--Final-orange)

---

## Technologies Used

- **.NET 8** (C#)
- **Blazor Server**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQLite** (for the TravelBridgeAPI database)
- **REST APIs**
- **HTTPClient** (for API communication)

---

## Team Members

| Name        | Responsibility                  |
|:------------|:---------------------------------|
| **Bo**      | Blazor Web Application (Gotorz)  |
| **Burak**   | Blazor Web Application (Gotorz)  |
| **Peter**   | TravelBridgeAPI development      |
| **Kenneth** | TravelBridgeAPI development      |

---

## Project Structure

| Path/Project           | Description                                             |
|:------------------------|:--------------------------------------------------------|
| `FullGotorz/`          | Root directory for the entire solution                 |
| `AuthAndUserAPI/`      | User authentication API                                |
| `Gotorz/`              | Blazor Server application (frontend)                   |
| `Gotorz.Client/`       | Minimal project for separation (not in active use)     |
| `TravelBridgeAPI/`     | API for flights and hotels (hosted externally)         |
| `Gotorz.sln`           | Full Visual Studio solution file                       |
| `.gitignore`           | Git ignore rules                                       |

Each project is a standalone application but is designed to work together as part of the Gotorz system.

---

## Running the Project

1. Clone the repository.
2. Open `Gotorz.sln` in Visual Studio.
3. Configure your IDE to launch **AuthAndUserAPI** and **Gotorz** projects simultaneously.
4. Run the solution.

**Note:**  
You do **not** need to run `TravelBridgeAPI` or `Gotorz.Client`.  
- `TravelBridgeAPI` is hosted 24/7 on a team member's home server.  
- `Gotorz.Client` is included only for structural purposes.