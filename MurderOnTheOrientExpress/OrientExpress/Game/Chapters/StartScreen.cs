
using OrientExpress.Game.ChapterContent; 

namespace OrientExpress.Game.Chapters
{
    public class StartScreen
    {
        public void StartGame()
        {
            bool gameStarted = true;

            while (gameStarted)
            {
                Console.Clear();
                Console.WriteLine(StartScreenText.Title);
                Console.WriteLine(StartScreenText.Introduction);
                Console.WriteLine(StartScreenText.Menu);

                Console.Write("Enter your choice: ");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Starting the investigation...");
                        gameStarted = false;
                        Prolog.Play();
                        break;

                    case "2":
                        ShowInstructions();
                        break;

                    case "3":
                        Console.WriteLine("Exiting game. Goodbye!");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        private void ShowInstructions()
        {
            Console.Clear();
            Console.WriteLine("=== How to Play ===");
            Console.WriteLine("- Use numbers to choose actions.");
            Console.WriteLine("- Investigate scenes, question suspects, collect clues.");
            Console.WriteLine("- Make the right deductions to solve the mystery.");
            Console.WriteLine("\nPress any key to return to the main menu...");
            Console.ReadKey();
        }
    }
}