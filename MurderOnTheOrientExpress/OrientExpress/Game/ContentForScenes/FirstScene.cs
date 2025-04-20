namespace OrientExpress.Game.ContentForScenes;

public class FirstScene
{
    public static class GameIntro
    {
        public static void Show()
        {
            Console.Clear();
            Console.WriteLine(@"
            The year is 1934.

            You are aboard the luxurious Orient Express, traveling from Istanbul to Calais.
            The train is packed with distinguished passengers from all corners of Europe.

            One of them is Samuel Ratchett — a wealthy American businessman with a dark past.

            This morning, Ratchett was found dead in his compartment. Stabbed. Repeatedly.

            The train is stuck in heavy snow in the middle of Yugoslavia.
            No one can get on. No one can get off.

            As the world-famous detective Hercule Poirot, 
            you have been asked to solve the murder before the train moves again.

            Everyone had a reason to want him dead.
            ");

            Console.WriteLine("\nPress any key to begin your investigation...");
            Console.ReadKey();
        }
    }

}