# -dcit318-assignment1-11300128

## 📘 README – DCIT318 Assignment 1
### 🔹 How to Run Each Program
1️⃣ Open a terminal in the project folder (e.g., Assignment1):bash
Copy
Edit
cd Assignment1.

### 2️⃣ Build & Run a Specific File

Because there are multiple files with their own Main() methods, you must tell dotnet which one to run:

▶ Grade Calculator

bash
Copy
Edit
##### dotnet run --project Assignment1.csproj --no-build -p:StartupObject=GradeCalculator
▶ Ticket Price Calculator

bash
Copy
Edit
##### dotnet run --project Assignment1.csproj --no-build -p:StartupObject=TicketPriceCalculator
▶ Triangle Type Identifier

bash
Copy
Edit
##### dotnet run --project Assignment1.csproj --no-build -p:StartupObject=TriangleTypeIdentifier

3️⃣ Follow the instructions in each program.

Type a number for input.

Type x anytime to exit that program.

✅ Requirements:

.NET 8 SDK installed

Works in VS Code, Visual Studio, or Command Prompt

