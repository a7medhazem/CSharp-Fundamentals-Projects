# 🧠 Quiz Game Console App

## 📋 Overview  
A simple C# console application that runs a general knowledge quiz.  
Users are asked a series of questions and get immediate feedback on their answers.

---

## 🚀 Features

- Ask the user 10 different general knowledge questions.
- Accept answers in any letter case (case-insensitive).
- Show if the answer is correct or incorrect.
- Display the correct answer when the user's answer is wrong.
- Use colored output (green/red) for better feedback.
- Display the total score and percentage at the end.
- Handle empty input with clear error messages.

---

## 🧱 How It Works

- Questions and answers are stored in `string[]` arrays.
- User answers are compared using `StringComparison.OrdinalIgnoreCase`.
- Score is tracked using a `double` variable.
- Input is validated with exception handling.
- Final results include total correct answers and percentage score.

---

## 💡 Tech Used

- C# (.NET Console App)
- Arrays
- Methods (`bool IsTheAnswerCorrect(...)`)
- Exception handling
- Colored Console Output (`Console.ForegroundColor`)
- Math functions (`Math.Round`)
- Console I/O

---

## ▶️ Run the App

Make sure you have .NET SDK installed, then run:

```bash
dotnet run
