
namespace OrientExpress.Game.Chapters
{
    public class Chapter1
    {
        private static HashSet<string> playerChoices = new HashSet<string>();

        public static void Play()
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter1.ChapterTitle);
            Console.WriteLine(ChapterContent.Chapter1.ChapterDescription);
            Console.WriteLine(ChapterContent.Chapter1.ChapterChoices);
            
            string playerChoice = Console.ReadLine();

            switch (playerChoice)
            {
                case "1":
                    if (!playerChoices.Contains("ExamineBody"))
                    {
                        ExamineBody();
                        playerChoices.Add("ExamineBody");
                    }
                    else
                    {
                        Console.WriteLine(ChapterContent.Chapter1.ExamineBody.AlreadyExamined);
                        Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                        Console.ReadKey();
                    }
                    break;
                
                case "2":
                    if (!playerChoices.Contains("LookForClues"))
                    {
                        LookForClues();
                        playerChoices.Add("LookForClues");
                    }
                    else
                    {
                        Console.WriteLine(ChapterContent.Chapter1.LookForClues.AlreadySearched);
                        Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                        Console.ReadKey();
                    }
                    break;
                
                case "3":
                    if (!playerChoices.Contains("SpeakToConductor"))
                    {
                        SpeakToConductor();
                        playerChoices.Add("SpeakToConductor");
                    }
                    else
                    {
                        Console.WriteLine(ChapterContent.Chapter1.SpeakToConductor.AlreadySpoken);
                        Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                        Console.ReadKey();
                    }
                    break;
                
                default:
                    Console.WriteLine(ChapterContent.Chapter1.Messages.InvalidChoice);
                    Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                    Console.ReadKey();
                    Play();
                    break;
            }

            if (playerChoices.Count == 3)
            {
                ShowSummary();
            }
            else
            {
                Play();
            }
        }

        private static void ExamineBody()
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter1.ExamineBody.Description);
            Console.WriteLine(ChapterContent.Chapter1.ExamineBody.Choices);
            
            string bodyChoice = Console.ReadLine();
            
            if (bodyChoice == "1")
            {
                Console.Clear();
                Console.WriteLine(ChapterContent.Chapter1.ExamineBody.PickUpNote);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
            }
            else if (bodyChoice == "2")
            {
                Console.Clear();
                Console.WriteLine(ChapterContent.Chapter1.ExamineBody.LeaveNote);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter1.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
                ExamineBody();
            }
        }

        private static void LookForClues()
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter1.LookForClues.Description);
            Console.WriteLine(ChapterContent.Chapter1.LookForClues.Choices);

            string clueChoice = Console.ReadLine();

            if (clueChoice == "1")
            {
                Console.Clear();
                Console.WriteLine(ChapterContent.Chapter1.LookForClues.ExamineWindow);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
            }
            else if (clueChoice == "2")
            {
                Console.Clear();
                Console.WriteLine(ChapterContent.Chapter1.LookForClues.ExamineDesk);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter1.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
                LookForClues();
            }
        }

        private static void SpeakToConductor()
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter1.SpeakToConductor.Description);
            Console.WriteLine(ChapterContent.Chapter1.SpeakToConductor.Choices);
            
            string conductorChoice = Console.ReadLine();

            if (conductorChoice == "1")
            {
                Console.Clear();
                Console.WriteLine(ChapterContent.Chapter1.SpeakToConductor.AskAboutMurder);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
            }
            else if (conductorChoice == "2")
            {
                Console.Clear();
                Console.WriteLine(ChapterContent.Chapter1.SpeakToConductor.AskAboutPassengers);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter1.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
                SpeakToConductor();
            }
        }

        private static void ShowSummary()
        {
            Console.Clear();
            Console.WriteLine(ChapterContent.Chapter1.ChapterSummary);
            
            Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.NextChapterChoices);
            
            string summaryChoice = Console.ReadLine();
            
            if (summaryChoice == "1")
            {
                Console.Clear();
                Chapter2.Play(); 
            }
            else if (summaryChoice == "2")
            {
                Console.WriteLine(ChapterContent.Chapter1.Messages.ThanksForPlaying);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine(ChapterContent.Chapter1.Messages.InvalidChoice);
                Console.WriteLine("\n" + ChapterContent.Chapter1.Messages.PressAnyKey);
                Console.ReadKey();
                ShowSummary(); 
            }
        }
    }
}