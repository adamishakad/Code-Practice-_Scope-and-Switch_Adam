namespace Code_Practice_Scope_and_Switch_Adam
{
    internal class Program
    {
        static void Main(string[] args)



        {
            Console.WriteLine("Math Quiz Menu:");
            Console.WriteLine("1. Multiplication");
            Console.WriteLine("2. Division");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");

            Random rnd = new Random();
            int num1 = rnd.Next(10, 12);
            int num2 = rnd.Next(9, 10);
            int answer = num1 * num2;

            Console.WriteLine($"What is {num1} * {num2}?");
           
            Random random = new Random();
            int totalTickets = rnd.Next(35, 110);
            int ticketsPerRide = rnd.Next(3, 9);
            int rides = totalTickets / ticketsPerRide;

            Console.WriteLine($"If you have {totalTickets} tickets for the fair and each ride costs " +
                $"{ticketsPerRide} tickets, how many rides can you go on?");

            Console.WriteLine("Correct!");
        }   
        
            

        
    }    
}
