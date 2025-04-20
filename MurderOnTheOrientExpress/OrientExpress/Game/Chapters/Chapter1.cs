using System;
using System.Collections.Generic;
using OrientExpress.Game.ChapterContent;

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
                        Console.WriteLine("You have already examined the body.");
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
                        Console.WriteLine("You have already searched for clues.");
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
                        Console.WriteLine("You have already spoken to the conductor.");
                    }
                    break;
                
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
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
            Console.WriteLine("You kneel down beside the body of Samuel Ratchett.");
            Console.WriteLine("He has been stabbed multiple times.");
            Console.WriteLine("You find a note with some strange symbols on it.");
            Console.WriteLine("What will you do?");
            Console.WriteLine("[1] Pick up the note.");
            Console.WriteLine("[2] Leave the note behind.");
            
            string bodyChoice = Console.ReadLine();
            
            if (bodyChoice == "1")
            {
                Console.Clear();
                Console.WriteLine("You pick up the note, take a quick look, put it in your pocket, and leave the room.");
            }
            else if (bodyChoice == "2")
            {
                Console.Clear();
                Console.WriteLine("You leave the note behind and continue searching the room.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                ExamineBody();
            }
        }

        private static void LookForClues()
        {
            Console.Clear();
            Console.WriteLine("You start searching the room. The walls are covered in dark wood paneling, and there's a small writing desk.");
            Console.WriteLine("You spot a broken window near the bed, as if someone tried to escape.");
            Console.WriteLine("\nWhat will you do?");
            Console.WriteLine("[1] Examine the window.");
            Console.WriteLine("[2] Look at the writing desk.");

            string clueChoice = Console.ReadLine();

            if (clueChoice == "1")
            {
                Console.WriteLine("You approach the window. It's broken, but there's no sign of anyone escaping through it.");
                Console.WriteLine("You find some footprints in the snow outside. Someone was likely here recently.");
            }
            else if (clueChoice == "2")
            {
                Console.WriteLine("You open the desk drawer and find a hidden compartment. Inside is a locked envelope, but you can't open it without a key.");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                LookForClues();
            }
        }

        private static void SpeakToConductor()
        {
            Console.Clear();
            Console.WriteLine("You step outside the room and find the conductor standing nearby.");
            Console.WriteLine("He looks nervous, his eyes darting about as if he's trying to avoid suspicion.");
            Console.WriteLine("\nWhat will you do?");
            Console.WriteLine("[1] Ask him about the murder.");
            Console.WriteLine("[2] Ask about the other passengers.");
            
            string conductorChoice = Console.ReadLine();

            if (conductorChoice == "1")
            {
                Console.WriteLine("The conductor looks uncomfortable. 'I... I didn't see anything,' he stammers. 'But I heard rumors...'");
            }
            else if (conductorChoice == "2")
            {
                Console.WriteLine("The conductor hesitates. 'The passengers... they're all suspicious in their own way. Everyone has secrets.'");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
                SpeakToConductor();
            }
        }

        private static void ShowSummary()
        {
            Console.Clear();
            Console.WriteLine("Chapter 1 Summary:");
            Console.WriteLine("You have investigated the murder scene, spoken to the conductor, and searched for clues.");
            Console.WriteLine("Here is what you have learned:");
            Console.WriteLine("- The victim was stabbed multiple times.");
            Console.WriteLine("- A strange note with symbols was found on the body.");
            Console.WriteLine("- Footprints outside the broken window suggest someone was here recently.");
            Console.WriteLine("- The conductor is nervous and seems to know something, but isn't revealing much.");
            Console.WriteLine("\nNow, you're ready to move on to the next chapter.");
        }
    }
}
