namespace BlackJack_dice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till Casino BlackJack!");


            Console.WriteLine("Vill du slå eller stanna?");
            string answer = Console.ReadLine();
            int playerSum = 0;

            while (answer != "stanna" && playerSum <=20)
            {
                Random rand = new Random();
                int diceThrow = rand.Next(1, 7);

                playerSum += diceThrow;
                if (playerSum == 21)
                {
                    Console.WriteLine(diceThrow + ", Summan är nu " + playerSum + ", du vann");
                    break;
                }
                    Console.WriteLine(diceThrow + ", Summan är nu " + playerSum);

                if (playerSum <= 21)
                {
                    Console.WriteLine("Vill du slå eller stanna?");
                    answer = Console.ReadLine();
                }
            }
            if (playerSum > 21)
            {
                Console.WriteLine("Du förlorade");
            }

            int dealerSum = 0;


            if (playerSum != 21)
            {
                Console.WriteLine("Nu ska dealern köra");


                while (dealerSum < 17)
                {
                    Random rand = new Random();
                    int diceThrow = rand.Next(1, 7);

                    dealerSum += diceThrow;
                    if (dealerSum == 21)
                    {
                        Console.WriteLine(diceThrow + ", Dealern har nu " + dealerSum + ", dealern vann");
                        break;
                    }
                    Console.WriteLine(diceThrow + ", Dealern har nu " + dealerSum);
                }
            }
                if (dealerSum > 21)
                {
                    Console.WriteLine("Dealern förlorade");
                }

                if (dealerSum < 21 && dealerSum > playerSum || dealerSum == 21 || playerSum > 21)
            {
                Console.WriteLine("Dealern vann");
            }
                else if (playerSum == dealerSum)
            {
                Console.WriteLine("Det är lika mycket, därför vinner dealern");
            }
                else if (playerSum < 21 && playerSum > dealerSum || playerSum == 21 || dealerSum > 21)
            {
                Console.WriteLine("Spelaren vann");
            }
        }
    }
}
