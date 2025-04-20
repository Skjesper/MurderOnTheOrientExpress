
namespace OrientExpress.Game.Chapters;

public class Chapter4
{
    public static void Play()
    {
        Console.Clear();
        Console.WriteLine(ChapterContent.Chapter4.ChapterTitle);
        Console.WriteLine(ChapterContent.Chapter4.ChapterDescription);
        Console.WriteLine(ChapterContent.Chapter4.ChapterChoices);

        string finalChoice = Console.ReadLine();

        Console.Clear();

        switch (finalChoice)
        {
            case "1":
                Console.WriteLine(ChapterContent.Chapter4.Answers.ConductorChoice);
                break;
            case "2":
                Console.WriteLine(ChapterContent.Chapter4.Answers.PassengerChoice);
                break;
            case "3":
                Console.WriteLine(ChapterContent.Chapter4.Answers.EveryoneChoice);
                break;
            default:
                Console.WriteLine(ChapterContent.Chapter4.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter4.Messages.PressAnyKey);
                Console.ReadKey();
                Play();
                return;
        }

        Console.WriteLine("\n" + ChapterContent.Chapter4.Epilogue);
        Console.WriteLine(ChapterContent.Chapter4.EpilogueChoices);

        string restart = Console.ReadLine();
        if (restart == "1")
        {
            Console.Clear();
            StartScreen startScreen = new StartScreen();
            startScreen.StartGame();
        }
        else if (restart == "2")
        {
            Console.WriteLine(ChapterContent.Chapter4.Goodbye);
        }
        else
        {
            Console.WriteLine(ChapterContent.Chapter4.Messages.InvalidChoice);
            Console.WriteLine("\n" + ChapterContent.Chapter4.Messages.PressAnyKey);
            Console.ReadKey();
            
            
            Console.WriteLine("\n" + ChapterContent.Chapter4.Epilogue);
            Console.WriteLine(ChapterContent.Chapter4.EpilogueChoices);
            
            restart = Console.ReadLine();
            if (restart == "1")
            {
                Console.Clear();
                StartScreen startScreen = new StartScreen();
                startScreen.StartGame();
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter4.Goodbye);
            }
        }
    }
}