namespace OrientExpress.Game.Chapters;

public class Prolog
{
    public static void Play()
    {
        Console.Clear();
        Console.WriteLine(ChapterContent.PrologText.GameIntro); 
        Console.WriteLine("Press any key to begin..");
        Console.ReadKey();
        Chapter1.Play();
        
    }
}