# 🔐 Cybersecurity Chatbot (C# Project)

## 📌 Overview

This project is a **Cybersecurity Chatbot** built in C#. It is designed to help users understand key cybersecurity concepts and stay safe online through an interactive console-based experience.

The application combines multiple features such as audio greetings, ASCII art logo display, and a keyword-based chatbot to create an engaging and educational tool.

## 🚀 Features

* Plays a welcome audio on startup
* Displays a logo as ASCII art in the console
* Console-based chatbot interaction
* Colored console interface for better user experience
* Prompts user for their name with validation
* Responds to cybersecurity-related questions
* Personalized responses using the user's name
* Keyword-based input matching
* Graceful exit using "exit" command

## 🛠️ Technologies Used

* C# (.NET Framework)
* `System.Media` for sound playback
* Visual Studio (recommended IDE)

## 📂 Project Structure

```
final_poe_part1/
│
├── Program.cs         # Entry point of the application
├── welcome_voice.cs   # Handles audio playback
├── chat_logo.cs       # Converts and displays logo as ASCII art
├── user_response.cs   # Handles chatbot interaction
├── user_interface.cs  # Manages user input/output
├── welcome.wav        # Audio file to be played
├── logo.jpg           # Image used for ASCII logo display
└── bin/Debug/         # Build output directory (auto-generated)
```

final_poe_part1/
│
├── Program.cs         # Entry point of the application
├── welcome_voice.cs   # Handles audio playback
├── chat_logo.cs       # Displays application logo (assumed)
├── user_response.cs   # Handles chatbot interaction
├── user_interface.cs  # Manages user input/output
├── welcome.wav        # Audio file to be played
└── bin/Debug/         # Build output directory (auto-generated)

```
final_poe_part1/
│
├── welcome_voice.cs   # Main class that handles audio playback
├── welcome.wav        # Audio file to be played
└── bin/Debug/         # Build output directory (auto-generated)
```

## ⚙️ How It Works

1. The program starts in `Program.cs` (Main method).
2. It initializes several classes:

   * `welcome_voice` → plays a welcome audio
   * `chat_logo` → converts and displays a logo image as ASCII art
   * `user_response` → handles chatbot logic
   * `user_interface` → manages user interaction
3. The interface system (`user_interface`):

   * Displays a styled welcome message
   * Prompts the user to enter their name
   * Validates input to ensure it is not empty
   * Greets the user personally
4. The logo system (`chat_logo`):

   * Loads an image (`logo.jpg`)
   * Converts it to grayscale
   * Maps pixel brightness to ASCII characters
   * Displays it in the console
5. The system then:

   * Displays example cybersecurity topics
6. The chatbot starts (`ai_chat` method):

   * The user types a question
   * Input is converted to lowercase
   * The program checks for keywords (e.g., "password", "phishing")
   * If a match is found, a predefined response is shown
   * If no match is found, a default message is displayed
   * Typing `exit` ends the chat session

## ▶️ Installation & Setup

1. Clone or download the project.
2. Open the project in Visual Studio.
3. Ensure the `welcome.wav` file is placed in the root project directory (not inside `bin/Debug`).
4. Build and run the project.

## 📢 Usage Example

```csharp
// Create an instance of the class
welcome_voice voice = new welcome_voice();
```

This will automatically play the welcome sound.

## ⚠️ Important Notes

* The `welcome.wav` file must exist in the correct directory, otherwise the program will throw an error.
* The project uses `PlaySync()`, which means the program will wait until the audio finishes playing before continuing.
* Path handling is based on removing `bin\Debug\` from the runtime directory.

## 🔧 Possible Improvements

* Replace `ArrayList` with `List<string>` for better type safety
* Implement more advanced natural language processing (NLP)
* Add more cybersecurity topics and responses
* Improve keyword matching (e.g., ignore filler words like "what", "is")
* Add a graphical user interface (GUI)
* Store responses externally (e.g., JSON or database)
* Add logging or chat history feature

## 💬 Chatbot Example

```
User: what is phishing?
CYBERBOT: Phishing is a scam where attackers pretend to be trusted companies...

User: password tips
CYBERBOT: A strong password should be long (8+ characters)...

User: exit
CYBERBOT: Bye! Enjoy the rest of your day
```
## 🖼️ Screenshots
<img width="653" height="120" alt="CI workflow" src="https://github.com/user-attachments/assets/abb52dee-236f-42ab-91b6-dcb969d98373" />



## 👨‍💻 Author

Created as part of a cybersecurity chatbot assignment.

Screenshot of a succesful CI workflow



