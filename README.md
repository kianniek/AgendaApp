# Smart Household Agenda

**Smart Household Agenda** is a desktop-based personal dashboard built with Electron and React. It is designed to run on a Raspberry Pi or a laptop, displaying your household's agenda including calendar events, weather updates, and news headlines.

## Scope and Vision

This project aims to create a smart agenda for home use. Phase 1 focuses on setting up the project structure and a "Hello World" baseline app.

## Prioritized Feature Map

1. Calendar Events Display – High Priority.
2. Weather Forecast – High Priority.
3. News Headlines – Medium Priority.
4. Configuration UI – Lower Priority.
5. Startup/Autorefresh – Medium Priority.

## Getting Started

### Prerequisites

- Node.js and npm installed.
- Clone this repository.

### Installation

```bash
npm install
```

### Running the Application

```bash
npm start
```

This command starts the Electron application. A window should display a "Hello, Smart Household Agenda!" message.

## Project Structure

- `electron/main.js` – Electron main process.
- `electron/preload.js` – Preload script.
- `src/` – React application.
- `src/index.html` – HTML template loaded in Electron.
- `src/index.jsx` – React entry point.

