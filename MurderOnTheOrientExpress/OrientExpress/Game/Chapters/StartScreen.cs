
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
                Console.WriteLine(StartScreenText.Prompt);
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
            Console.WriteLine(StartScreenText.HowToPlay);
            Console.WriteLine("\n" + StartScreenText.PressAnyKey);
            Console.ReadKey();
        }
    }
}