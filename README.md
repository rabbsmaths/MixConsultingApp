# MiX Consulting Profile Management Engine

**Enterprise Administration Workspace | .NET 8.0 | 3-Tier Architecture**

---

# 1. Architectural Philosophy

The system is built on a **3-Tier Architecture** that enforces a clean separation of concerns, ensuring the application remains maintainable, secure, and scalable.

## A. Presentation Layer (`MiX_Consulting.Presentation`)

**Role:** User interface and user interaction management.

**Technology:** Krypton Toolkit for modern, flat-design UI.

**Security:** Implements a global `IMessageFilter` that intercepts Win32 messages (`WM_MOUSEMOVE`, `WM_LBUTTONDOWN`, `WM_KEYDOWN`) to maintain a rolling session-timeout heartbeat.

---

## B. Domain Layer (`MiX_Consulting.Domain`)

**Role:** The source of truth for business logic.

### Domain Models

Uses classic **Encapsulation** (private fields + explicit Get/Set logic) to enforce business rules internally before data is committed.

### DTOs (Data Transfer Objects)

Uses "anemic" models (auto-implemented properties) to serve as lightweight data carriers. This decouples the UI from the database, allowing SQL tables to be refactored without breaking forms.

---

## C. Infrastructure Layer (`MiX_Consulting.Infrastructure`)

**Role:** Data access and external integration.

### Query Engine

Uses **Dapper Micro-ORM** for high-performance data mapping.

Dapper is preferred over EF Core for its raw speed and transparency, and over ADO.NET for its ability to auto-map SQL results directly into DTOs without manual boilerplate code.

### Security & Auditing

Uses:

* **BCrypt.Net-Next** for secure password hashing.
* **NLog** for high-fidelity security logging (e.g., failed logins, session terminations).

---

# 2. Security: Why BCrypt.Net-Next?

For password security, this engine utilizes **BCrypt.Net-Next** because it is the industry standard for modern .NET applications.

## Automatic Salting

BCrypt.Net-Next automatically handles the generation and storage of a unique salt for every password.

This eliminates the risk of **Rainbow Table attacks**, where attackers use pre-computed hash lists.

## .NET 8 Compatibility

Fully optimized for modern .NET 8 runtimes, providing a thread-safe, high-performance implementation that integrates easily into repository-based architectures.

---

# 3. Deployment & Setup

## Prerequisites

* Visual Studio 2022 (v17.8+)
* .NET 8.0 SDK
* SQL Server 2019+

---

## Initialization Steps

### 1. Database Setup

Execute the `Docs/Schema.sql` script in your SQL Server instance.

### 2. Create Initial Administrator Account

```sql
INSERT INTO Users (Username, PasswordHash, IsAdmin)
VALUES (
    'Admin',
    '$2a$11$f5/nKjJpW.99wJ1y3OaMue3e.1.aLhH0J6s9K5J1h3o2K4P5lM6uW',
    1
);
```

### 3. Configure Connectivity

Update the `DefaultConnection` string in `appsettings.json` within the Presentation layer to point to your SQL Server instance.

### 4. Run the Application

1. Set `MiX_Consulting.Presentation` as the **Startup Project**.
2. Press **F5** to launch the application.

---

## Login Credentials

| Field    | Value         |
| -------- | ------------- |
| Username | `Admin`       |
| Password | `Password123` |

---

# 4. Engineering Standards

## Encapsulation

By separating business models (with validation logic) from DTOs (used for data transmission), the system avoids the leaky abstractions commonly found in smaller projects.

## Database Control

By using Dapper, developers maintain full authority over SQL execution plans, ensuring that complex joins and queries remain highly optimized for specific business requirements.

---

# Technology Stack Summary

| Layer          | Technology                          |
| -------------- | ----------------------------------- |
| Presentation   | Windows Forms + Krypton Toolkit     |
| Domain         | Encapsulated Business Models + DTOs |
| Infrastructure | Dapper Micro-ORM                    |
| Authentication | BCrypt.Net-Next                     |
| Logging        | NLog                                |
| Database       | SQL Server 2019+                    |
| Runtime        | .NET 8.0                            |

---

## Key Benefits

* Clean 3-tier architecture
* Strong separation of concerns
* High-performance data access with Dapper
* Secure password storage using BCrypt
* Comprehensive security auditing with NLog
* Scalable and maintainable enterprise design
* Full SQL control and optimization capabilities
