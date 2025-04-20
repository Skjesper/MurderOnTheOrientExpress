Murder on the Orient Express - Text Adventure
This is an interactive text-based mystery game inspired by Agatha Christie's classic novel "Murder on the Orient Express." Take on the role of detective Hercule Poirot and solve the murder aboard the famous train.
Game Overview
As the world-famous detective Hercule Poirot, you must solve a murder that has taken place aboard the Orient Express while it's stranded in heavy snow. Interview passengers, examine the crime scene, and piece together clues to uncover the truth behind Samuel Ratchett's death.
Getting Started with Rider
Follow these steps to run the game in JetBrains Rider:

Clone the Repository:
git clone https://github.com/your-username/MurderOnTheOrientExpress.git

Open the Project in Rider:

Launch Rider
Select "Open" and navigate to the cloned repository
Open the MurderOnTheOrientExpress.sln solution file


Configure Project Settings:

Ensure the project is set up as a console application
Verify that OutputType is set to Exe in the .csproj file
Make sure the project is using the correct .NET version (8.0)


Run the Application:

Click the "Run" button (green play icon) in the top toolbar
Alternatively, press Shift+F10 or use the menu: Run > Run


Playing the Game:

Use the number keys to select options when prompted
Follow the narrative and make choices to progress through the mystery
Press any key when prompted to continue the story



Project Structure
The game is organized using the following structure:

Game/Chapters/: Contains the main gameplay logic for each chapter
Game/ChapterContent/: Stores all the text content displayed during gameplay
Program.cs: Entry point for the application

Features

Immersive storytelling set in the 1930s aboard the Orient Express
Multiple-choice decision-making that affects the storyline
Four distinct chapters with unique challenges and revelations
Classic murder mystery gameplay with clues, suspects, and deduction

Requirements

.NET 8.0 SDK
JetBrains Rider (or any .NET-compatible IDE)

Notes for Developers

The project uses a clean separation between game logic and content text
All text is centralized in the ChapterContent namespace for easy modification
The game flow follows a chapter-based structure with branching paths

Enjoy solving the mystery aboard the Orient Express!
