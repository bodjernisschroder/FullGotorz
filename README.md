Gotorz - Exam Project Team 7

Welcome to **Gotorz**, our final exam project that combines a Blazor Web App and a supporting Web API architecture for a complete travel package booking experience!

---

Technologies Used

- **.NET 8** (C#)
- **Blazor Server**
- **ASP.NET Core Web API**
- **Entity Framework Core**
- **SQLite** (for the TravelBridgeAPI database)
- **REST APIs**
- **HTTPClient** (for API communication)

---

Team Members

| Name        | Responsibility                  |
|:------------|:---------------------------------|
| **Bo**      | Blazor Web Application (Gotorz)  |
| **Burak**   | Blazor Web Application (Gotorz)  |
| **Peter**   | TravelBridgeAPI development      |
| **Kenneth** | TravelBridgeAPI development      |

---

Project Structure

FullGotorz/  
AuthAndUserAPI/     # User authentication API  
Gotorz/             # Blazor Server application (frontend)  
Gotorz.Client/      # (Minimal, kept for project separation)  
TravelBridgeAPI/    # Flights and hotels database API  
Gotorz.sln          # Full solution file  
.gitignore          # Git ignore rules  

Each project is a standalone application but designed to work together as part of the Gotorz system.

---

Running The Project

1. Clone the respository
2. Doubleclick the .sln file in the root folder
3. Set your IDE to start the AuthAndUserAPI and Gotorz projects at the same time
4. Run the application

Leave TravelBridgeAPI and Gotorz.Client off. The project is only running on the client side, and the TravelBridgeAPI is running 24/7 on a teammembers home server, so there's no need to run it locally.