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
3. Set up Visual Studio to start **all four projects** simultaneously:
   - `Gotorz` (Blazor Server frontend)
   - `AuthAndUserAPI` (Authentication API)
   - `TravelBridgeAPI` (Flights & Hotels API)
   - `Gotorz.Client` (Included for structure—runs but minimal)
4. Run the solution.

**Note:**  
To run multiple startup projects in Visual Studio:
- Right-click the **solution** in Solution Explorer and choose **"Set Startup Projects..."**  
- In the dialog, select **"Multiple startup projects"**  
- Set **Action** to `Start` for all four projects  
- Reorder if necessary (optional)  
- Click **OK**, then run the solution normally

This ensures the frontend and both APIs are available and communicating as intended.