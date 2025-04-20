namespace OrientExpress.Game.ChapterContent;

public static class Chapter4
{
    public static readonly string ChapterTitle = @"
            Chapter 4: The Truth";

    public static readonly string ChapterDescription = @"
            You gather everyone in the dining car.
            You now must decide: who killed Samuel Ratchett?";

    public static readonly string ChapterChoices = @"
            [1] The conductor
            [2] One of the passengers
            [3] Everyone took part";
    
    public static class Answers
    {
        public static readonly string ConductorChoice = @"
            Incorrect. The conductor was hiding something, but he wasn't the killer.";
        
        public static readonly string PassengerChoice = @"
            Partly true. But it's more complex than that...";
        
        public static readonly string EveryoneChoice = @"
            Correct. Each passenger had a motive and played a role in the murder.
            It was justice, not murder. Ratchett was the gangster Cassetti, who ruined many lives.
            And so, they planned the perfect revenge — together.";
    }
    
    public static readonly string Epilogue = @"
            Thank you for playing.
            Would you like to restart?";
            
    public static readonly string EpilogueChoices = @"
            [1] Yes
            [2] No";
            
    public static readonly string Goodbye = @"
            Goodbye.";
            
   
    public static class Messages
    {
        public static readonly string InvalidChoice = @"
            Invalid choice. Please select a valid option.";
            
        public static readonly string PressAnyKey = @"
            Press any key to continue...";
    }
}