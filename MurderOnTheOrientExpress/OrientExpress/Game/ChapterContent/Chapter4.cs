namespace OrientExpress.Game.ChapterContent;

public static class Chapter4
{
    public static string ChapterTitle = @"
            Chapter 4: The Truth";

    public static string ChapterDescription = @"
            You gather everyone in the dining car.
            You now must decide: who killed Samuel Ratchett?";

    public static string ChapterChoices = @"
            [1] The conductor
            [2] One of the passengers
            [3] Everyone took part";
    
    public static class Answers
    {
        public static string ConductorChoice = @"
            Incorrect. The conductor was hiding something, but he wasn't the killer.";
        
        public static string PassengerChoice = @"
            Partly true. But it's more complex than that...";
        
        public static string EveryoneChoice = @"
            Correct. Each passenger had a motive and played a role in the murder.
            It was justice, not murder. Ratchett was the gangster Cassetti, who ruined many lives.
            And so, they planned the perfect revenge — together.";
    }
    
    public static string Epilogue = @"
            Thank you for playing.
            Would you like to restart?";
            
    public static string EpilogueChoices = @"
            [1] Yes
            [2] No";
            
    public static string Goodbye = @"
            Goodbye.";
            
   
    public static class Messages
    {
        public static string InvalidChoice = @"
            Invalid choice. Please select a valid option.";
            
        public static string PressAnyKey = @"
            Press any key to continue...";
    }
}