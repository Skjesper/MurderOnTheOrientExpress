namespace OrientExpress.Game.ChapterContent;

public static class Chapter3
{
    public static readonly string ChapterTitle = @"
            Chapter 3: Revelations";

    public static readonly string ChapterDescription = @"
            Clues and contradictions begin to surface.
            You now have to piece together the timeline of the murder.
            Where was everyone when Ratchett was killed?";

    public static readonly string ChapterChoices = @"
            [1] Reconstruct timeline.
            [2] Re-interview a suspect.";
    
    public static readonly string ChapterChoiceAnswer1 = @"
            You examine the timeline. Some testimonies don't align.
            - A passenger heard a cry at 12:15am.
            - The train stopped at 12:30 due to snow.
            - A knock on Ratchett's door was heard at 1:00am.
            The timeline narrows the window of the murder. It had to happen before 12:30.";
    
    public static readonly string ChapterChoiceAnswer2 = @"
            You re-interview the conductor. Under pressure, he confesses:
            'I saw someone in a red kimono leave the victim's cabin around midnight...'
            
            
            But why did he lie about that, could he be a bigger part in this? Poirot says.";
            
    public static readonly string ChapterSummary = @"
            You feel you're getting closer to the truth.";
    
    public static class Messages
    {
        public static readonly string InvalidChoice = @"
            Invalid choice. Please select a valid option.";
            
        public static readonly string PressAnyKey = @"
            Press any key to continue...";
            
        public static readonly string NextChapterChoices = @"
            [1] Continue to final chapter
            [2] Exit";
            
        public static readonly string ThanksForPlaying = @"
            Thanks for playing!";
    }
}