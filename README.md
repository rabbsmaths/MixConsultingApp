# MiX Consulting Profile Management Engine

An enterprise-grade, high-performance administration desktop workspace built using **VB.NET (.NET 8.0)** following rigorous **Domain-Driven Design (DDD)** decoupling paradigms.

## 🏢 Structural Boundaries & System Normalization

### 1. Presentation Layer (`MiX_Consulting.Presentation`)
- **UI Architecture:** Renders modern flat environments natively leveraging the open-source **Krypton Toolkit**, discarding legacy square WinForms components.
- **Sliding Security Handlers:** Implements custom `IMessageFilter` configurations hooking directly into underlying Win32 window message queues. It continuously updates a rolling 15-minute operational limit across all focus areas. If breached, it intercepts active threads, completely isolates visual data grids from visibility, and requires re-authentication.

### 2. Domain Layer (`MiX_Consulting.Domain`)
- **Entity Normalization:** Implements pure Object-Oriented models with private backing fields and explicit validation properties using structured `Get` and `Set` methods. 
- **Decoupled Architecture:** Contains zero references to data tracking framework engines, external component modules, or database contexts.

### 3. Infrastructure Layer (`MiX_Consulting.Infrastructure`)
- **Data Query Engine:** Employs **Dapper Micro-ORM** optimization routines to execute fast many-to-many joins across associative bridge mappings (`CompanyAddresses`). This resolves scenarios where multiple different corporate structures inhabit the identical office location without replicating data strings.
- **Auditing Infrastructure:** Integrates targeted **NLog** channels. General operational diagnostic paths flow into log targets while compliance updates loop directly into specialized files (`security-audit-*.log`).

## 🚀 Assembly and Execution Verification
1. Run the database configuration logic contained inside the `schema.sql` model script against your local SQL Express container.
2. Confirm connection parameters within `appsettings.json` address your local active data instances accurately.
3. Launch the primary solution project within Visual Studio, compile all layers, and initialize application tracking processes (`F5`).