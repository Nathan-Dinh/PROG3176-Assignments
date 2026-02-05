# PROG3176 Assignment 1 - Secret Agents API

A RESTful Web API for managing secret agents built with ASP.NET Core and Entity Framework Core.

## Domain Model: Agents

### Overview

The **Agents** domain represents individuals operating as secret agents within the system. Each agent is a distinct entity with identifying information and operational status tracking.

### Entity Definition

| Property  | Type     | Constraints                 | Description                                     |
| --------- | -------- | --------------------------- | ----------------------------------------------- |
| Id        | `int`    | Primary Key, Auto-increment | Unique identifier for the agent                 |
| FirstName | `string` | Required                    | Agent's first name                              |
| LastName  | `string` | Required                    | Agent's last name                               |
| CodeName  | `string` | Optional                    | Agent's alias or code designation (e.g., "007") |
| Active    | `bool`   | Default: `false`            | Indicates if the agent is currently active      |

### Business Rules

1. **Identity**: Each agent must have a unique system-generated identifier
2. **Naming**: First and last names are mandatory for agent registration
3. **Code Names**: Code names are optional and used for operational anonymity
4. **Status**: Agents default to inactive status upon creation and must be explicitly activated

### Domain Boundaries

The Agents domain is self-contained and represents the core entity of this system. It follows the principle of a single aggregate root with no external entity dependencies.

## Getting Started

```bash
# Restore dependencies
dotnet restore

# Apply database migrations
dotnet ef database update

# Run the application
dotnet run
```
