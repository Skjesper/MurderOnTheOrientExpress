namespace OrientExpress.Game.Chapters;

class Chapter3
{
    public static void Play()
    {
        Console.Clear();
        Console.WriteLine(ChapterContent.Chapter3.ChapterTitle);
        Console.WriteLine(ChapterContent.Chapter3.ChapterDescription);
        Console.WriteLine(ChapterContent.Chapter3.ChapterChoices);

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter3.ChapterChoiceAnswer1);
        }
        else if (choice == "2")
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter3.ChapterChoiceAnswer2);
        }
        else
        {
            Console.WriteLine(ChapterContent.Chapter3.Messages.InvalidChoice);
            Console.WriteLine("\n" + ChapterContent.Chapter3.Messages.PressAnyKey);
            Console.ReadKey();
            Play();
            return;
        }

        Console.WriteLine("\n" + ChapterContent.Chapter3.Messages.PressAnyKey);
        Console.ReadKey();

        PromptForNextChapter();
    }

    private static void PromptForNextChapter()
    {
        bool validChoice = false;

        while (!validChoice)
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter3.ChapterSummary);
            Console.WriteLine(ChapterContent.Chapter3.Messages.NextChapterChoices);
            
            string input = Console.ReadLine();
            
            if (input == "1") 
            {
                validChoice = true;
                Console.Clear();
                Chapter4.Play();
            }
            else if (input == "2")
            {
                validChoice = true;
                Console.WriteLine(ChapterContent.Chapter3.Messages.ThanksForPlaying);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter3.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter3.Messages.PressAnyKey);
                Console.ReadKey();
            }
        }
    }
}