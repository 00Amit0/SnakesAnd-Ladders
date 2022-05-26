namespace SnakesAndLadders
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Let's play snake and Ladders!");

            //Dice dc = new Dice();
            //dc.game();

            Snake_Ladder sk = new Snake_Ladder();
            sk.game();
        }
    }
}
