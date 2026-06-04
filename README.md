MiX Consulting Profile Management Engine
Enterprise Administration Workspace | .NET 8.0 | 3-Tier Architecture

1. Architectural Philosophy
The system is built on a 3-Tier Architecture that enforces a clean separation of concerns, ensuring the application remains maintainable, secure, and scalable.

A. Presentation Layer (MiX_Consulting.Presentation)
Role: User interface and user interaction management.

Technology: Krypton Toolkit for modern, flat-design UI.

Security: Implements a global IMessageFilter that intercepts Win32 messages (WM_MOUSEMOVE, WM_LBUTTONDOWN, WM_KEYDOWN) to maintain a rolling session-timeout heartbeat.

B. Domain Layer (MiX_Consulting.Domain)
Role: The "Source of Truth" for business logic.

Domain Models: Uses classic Encapsulation (private fields + explicit Get/Set logic) to enforce business rules internally before data is committed.

DTOs (Data Transfer Objects): Uses "anemic" models (auto-implemented properties) to serve as lightweight data carriers. This decouples the UI from the database, allowing you to refactor SQL tables without breaking your forms.

C. Infrastructure Layer (MiX_Consulting.Infrastructure)
Role: Data access and external integration.

Query Engine: Uses Dapper Micro-ORM for high-performance data mapping. Dapper is preferred over EF Core for its raw speed and transparency, and over ADO.NET for its ability to auto-map SQL results directly into your DTOs without manual boilerplate code.

Security & Auditing: Uses BCrypt.Net-Next for secure password hashing and NLog for high-fidelity security logging (e.g., failed logins, session terminations).

2. Security: Why BCrypt.Net-Next?
For password security, this engine utilizes BCrypt.Net-Next because it is the industry standard for modern .NET applications:

Work Factor (Cost): Unlike older hashing algorithms (like MD5 or SHA), BCrypt is "slow by design." You can increase the work factor as hardware gets faster, making brute-force attacks computationally infeasible.

Automatic Salting: BCrypt.Net-Next automatically handles the generation and storage of a unique salt for every password. This eliminates the risk of "Rainbow Table" attacks where attackers use pre-computed hash lists.

.NET 8 Compatibility: It is fully optimized for modern .NET 8 runtimes, providing a thread-safe, high-performance implementation that is easy to integrate into your repository pattern.

3. Deployment & Setup
Prerequisites
Visual Studio 2022 (v17.8+).

.NET 8.0 SDK.

SQL Server 2019+.

Initialization Steps
Database: Execute the Docs/Schema.sql script in your SQL instance.

Admin Account: Run this query to provision your first admin:

SQL
INSERT INTO Users (Username, PasswordHash, IsAdmin)
VALUES ('Admin', '$2a$11$f5/nKjJpW.99wJ1y3OaMue3e.1.aLhH0J6s9K5J1h3o2K4P5lM6uW', 1);
3.  **Connectivity:** Update the `DefaultConnection` string in `appsettings.json` within the Presentation layer to point to your local instance.
4.  **Run:** Set `MiX_Consulting.Presentation` as the **Startup Project** and press **F5**.

### Login Credentials
* **Username:** `Admin`
* **Password:** `Password123`


