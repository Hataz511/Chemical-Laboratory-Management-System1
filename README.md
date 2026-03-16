# Chemical-Laboratory-Management-System
Chemical Laboratory Management System (CLMS) – A digital platform for managing chemical inventory, safety, experiment tracking, and laboratory operations.
System Objectives

The primary objectives of CLMS are:

Ensure full traceability of chemical lifecycle (from acquisition to disposal)

Improve laboratory safety through controlled access and automated alerts

Enforce compliance with laboratory safety standards and internal policies

Reduce manual administrative workload

Provide real-time visibility into laboratory operations

Establish an auditable and transparent governance framework

Core Functional Modules
1. User & Access Management

Role-Based Access Control (RBAC)

Secure authentication with JWT

Multi-level authorization workflows

Account activity logging

2. Chemical Inventory Management

Chemical registration with metadata (CAS number, hazard class, storage location)

Expiry date monitoring with automated alerts

Minimum stock threshold notifications

Inventory movement history tracking

3. Request & Approval Workflow

Chemical request submission

Multi-level approval (Professor → Lab Supervisor → Safety Officer)

Automated status updates

Decision logging with mandatory comments

4. Experiment Tracking

Experiment registration

Linked chemical consumption tracking

Research traceability records

Secure archival of experiment history

5. Equipment Management

Equipment reservation scheduling

Conflict detection

Maintenance tracking

Usage monitoring

6. Safety & Compliance

Hazard classification enforcement

Incident reporting system

Immutable audit log

Waste management tracking

Non-Functional Requirements

Response time under 2 seconds

Secure password hashing (bcrypt)

HTTPS enforced communication

Protection against SQL Injection and XSS

Minimum 99% availability

Scalable architecture for future expansion

Clean and maintainable code structure

System Architecture (Planned)

CLMS will follow a layered architecture:

Presentation Layer (Frontend)

Application Layer (Backend REST API)

Data Layer (PostgreSQL Database)

The system will implement separation of concerns to ensure maintainability and scalability.

Security Considerations

Encrypted communication (HTTPS)

JWT-based session handling

Role-based authorization checks

Input validation (frontend and backend)

Database access control

Regular backup and recovery strategy

Repository Structure
chemical-laboratory-management-system/
│
├── backend/
├── frontend/
├── docs/
├── .gitignore
├── README.md
Development Roadmap

Phase 1:

Project setup

Authentication system

Basic inventory management

Phase 2:

Request approval workflow

Experiment logging

Equipment reservation module

## User Stories Prioritare (Must Have)
- US-01: User Registration
- US-02: Secure Login (2FA)
- US-03: Role-Based Access
- US-04: Register Chemical
- US-05: Expiry Alert
- US-06: Minimum Stock Alert
- US-07: Request Chemical
- US-08: Multi-Level Approval
- US-10: Automatic Quantity Deduction
- US-12: Hazard Access Restriction
- US-18: Immutable Audit Log
- US-20: Automated Backup
- US-21: Performance Requirement

## Teknologjitë e Përdorura
- Backend: Node.js + Express / Spring Boot / Django
- Database: PostgreSQL / MySQL
- Frontend: React / Angular
- Auth: JWT + 2FA
- Notifications: Email / Push Notifications
- Version Control: Git + GitHub

## Strukturë Projekti
- `/backend`: logjika server, routes, controllers, models
- `/frontend`: React/Angular components dhe pages
- `.gitignore`: për të shmangur files të panevojshme
- `README.md`: ky dokument

## Instalimi dhe Run
1. Klono repository:
```bash
git clone https://github.com/Hataz511/Chemical-Laboratory-Management-System1.git

Phase 3:

Advanced reporting

AI forecasting module

Security hardening & optimization

Academic Purpose

This repository is created as part of a university coursework assignment focused on version control, repository management, and software project structuring using Git and GitHub.
