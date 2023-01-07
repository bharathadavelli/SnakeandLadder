namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Snake & Ladder Simulator");
            int position = 0;
            Console.WriteLine("Welcome Player 1");
            Console.WriteLine("Player 1 is at position : " + position);

            Random random = new Random();
            Random random = new Random();

            while (position <= 100)
            {

                int temp = position;

                int die = random.Next(1, 7);
                Console.WriteLine("Player rolls a die and get : {0}", die);
@@ -40,6 + 40,10 @@ static void Main(string[] args)
                {
                    position = 0;
                }
                else if (position > 100)
                {
                    position = temp;
                }
                Console.WriteLine("Player current position is : " + position);
            }
            Console.WriteLine("Current Position is : {0}", position);
        }
    }
}