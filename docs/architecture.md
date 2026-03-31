# Architecture

Project follows a layered architecture.

## Models
Holds domain entities: Chemical, User, ChemicalRequest.

## Services
Contains business logic and application rules.

## Data
Handles data persistence with Repository Pattern (FileRepository CSV).

## UI
Handles user interaction (Console or API).

### Design Decisions
- Repository Pattern decouples data access.
- Separation of concerns applied.
- Program.cs minimal; DI used for Services and Repositories.

## SOLID Principles
- SRP: Each class has a single responsibility.
- OCP: Classes open for extension, closed for modification.
- LSP: Subtypes maintain behavior of base types.
- ISP: Interfaces minimal and specific (IRepository<T>).
- DIP: High-level modules depend on abstraction (IRepository<T>), not concrete FileRepository.