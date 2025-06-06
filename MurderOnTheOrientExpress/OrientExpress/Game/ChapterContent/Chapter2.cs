﻿namespace OrientExpress.Game.ChapterContent;

public static class Chapter2
{
    public static readonly string ChapterTitle = @"
            Chapter 2: The Passengers";

    public static readonly string ChapterDescription = @"
            You begin questioning the passengers. Each one has a different story.
            The Orient Express is filled with people from different backgrounds, each with their own secrets.";

    public static readonly string ChapterChoices = @"
            Who would you like to talk to?
            
            [1] The Countess Elena Andrenyi
            [2] Colonel Arbuthnot
            [3] Miss Mary Debenham";
            
    public static readonly string ChapterSummary = @"
            You've spoken to all passengers. Some stories don't quite add up.
            You begin to sense that the truth is hidden beneath layers of lies.";
    
    public static class Countess
    {
        public static readonly string Description = @"
            Elena Andrenyi appears calm, too calm.
            'I stayed in my compartment all night,' she says. 'I heard nothing.'";
            
        public static readonly string AlreadySpoken = @"
            You have already spoken to the Countess.";
    }
    
    public static class Colonel
    {
        public static readonly string Description = @"
            Colonel Arbuthnot grunts. 'Ratchett was scum. But I didn't kill him.'";
            
        public static readonly string AlreadySpoken = @"
            You have already spoken to the Colonel.";
    }
    
    public static class Mary
    {
        public static readonly string Description = @"
            Mary Debenham fidgets. 'I was asleep. I didn't hear anything until morning.'";
            
        public static readonly string AlreadySpoken = @"
            You have already spoken to Mary.";
    }
    
    public static class Messages
    {
        public static readonly string InvalidChoice = @"
            Invalid choice. Please select a valid option.";
            
        public static readonly string PressAnyKey = @"
            Press any key to continue...";
            
        public static readonly string NextChapterChoices = @"
            [1] Continue to Chapter 3
            [2] Exit";
            
        public static readonly string ThanksForPlaying = @"
            Thanks for playing!";
    }
}