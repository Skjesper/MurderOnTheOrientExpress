namespace OrientExpress.Game.ChapterContent;

public static class Chapter1
{
    public static readonly string ChapterTitle = @"
            Chapter 1: The Murder Scene";

    public static readonly string ChapterDescription = @"
            You arrive at Cabin No. 2 where the body of Samuel Ratchett lies still.

            The room is dim, the air heavy. A shattered watch lies on the floor—
            stopped exactly at 1:15 AM.

            Outside, the train is silent in the snow.

            You must begin your investigation.";

    public static readonly string ChapterChoices = @"
            What will you do?
            
            [1] Examine the body
            [2] Look for clues in the room
            [3] Speak to the conductor";

    public static readonly string ChapterSummary = @"
            Chapter 1 Summary:
            You have investigated the murder scene, spoken to the conductor, and searched for clues.
            Here is what you have learned:
            - The victim was stabbed multiple times.
            - A strange note with symbols was found on the body.
            - Footprints outside the broken window suggest someone was here recently.
            - The conductor is nervous and seems to know something, but isn't revealing much.

            Now, you're ready to move on to the next chapter.";
    
    public static class ExamineBody
    {
        public static readonly string Description = @"
            You kneel down beside the body of Samuel Ratchett.
            He has been stabbed multiple times.
            You find a note with some strange symbols on it.";
        
        public static readonly string Choices = @"
            What will you do?
            [1] Pick up the note.
            [2] Leave the note behind.";
        
        public static readonly string PickUpNote = @"
            You pick up the note, take a quick look, put it in your pocket, and leave the room.";
        
        public static readonly string LeaveNote = @"
            You leave the note behind and continue searching the room.";
            
        public static readonly string AlreadyExamined = @"
            You have already examined the body.";
    }
    
    public static class LookForClues
    {
        public static readonly string Description = @"
            You start searching the room. The walls are covered in dark wood paneling, and there's a small writing desk.
            You spot a broken window near the bed, as if someone tried to escape.";
        
        public static readonly string Choices = @"
            What will you do?
            [1] Examine the window.
            [2] Look at the writing desk.";
        
        public static readonly string ExamineWindow = @"
            You approach the window. It's broken, but there's no sign of anyone escaping through it.
            You find some footprints in the snow outside. Someone was likely here recently.";
        
        public static readonly string ExamineDesk = @"
            You open the desk drawer and find a hidden compartment. Inside is a locked envelope, but you can't open it without a key.";
            
        public static readonly string AlreadySearched = @"
            You have already searched for clues.";
    }
    
    public static class SpeakToConductor
    {
        public static readonly string Description = @"
            You step outside the room and find the conductor standing nearby.
            He looks nervous, his eyes darting about as if he's trying to avoid suspicion.";
        
        public static readonly string Choices = @"
            What will you do?
            [1] Ask him about the murder.
            [2] Ask about the other passengers.";
        
        public static readonly string AskAboutMurder = @"
            The conductor looks uncomfortable. 'I... I didn't see anything,' he stammers. 'But I heard rumors...'";
        
        public static readonly string AskAboutPassengers = @"
            The conductor hesitates. 'The passengers... they're all suspicious in their own way. Everyone has secrets.'";
            
        public static readonly string AlreadySpoken = @"
            You have already spoken to the conductor.";
    }
    
    public static class Messages
    {
        public static readonly string InvalidChoice = @"
            Invalid choice. Please select a valid option.";
            
        public static readonly string PressAnyKey = @"
            Press any key to continue...";
            
        public static readonly string NextChapterChoices = @"
            [1] Continue with Chapter 2
            [2] Exit";
            
        public static readonly string ThanksForPlaying = @"
            Thanks for playing!";
    }
}