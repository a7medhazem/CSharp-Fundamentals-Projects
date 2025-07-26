# Task Tracker Console App

## 📋 Overview
A simple C# console application to manage tasks.  
Users can add, view, complete, and remove tasks using a numbered menu system.

## 🚀 Features
- [0] View Options
- [1] Add Task
- [2] View All Tasks
- [3] Mark Task as Complete
- [4] Remove Task
- [5] Exit

## 🧱 How It Works
- Tasks are stored in a fixed-size array (up to 100).
- Tasks can be marked as `--> completed`.
- Tasks can be removed by their number.
- Input is validated using `int.TryParse`.

## 💡 Tech Used
- C# (.NET Console App)
- Arrays
- Methods
- Switch Statements
- Console I/O
- `Environment.Exit(0)`

## ▶️ Run the App
Make sure .NET SDK is installed, then run:

```bash
dotnet run
