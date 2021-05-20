using System;

namespace DinerAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            int[] tableSeats = { 5, 6, 8, 9, 1, 5, 4, 3 }; // The amount of free seats at the tables
            while (isOpen)
            {
                Console.SetCursorPosition(0, 15);
                for (int i = 0; i < tableSeats.Length; i++)
                {
                    Console.WriteLine($"At th table - {i + 1} there're {tableSeats[i]} available seats.");
                }
                Console.SetCursorPosition(20, 0);
                Console.WriteLine("The Diner Administration");
                Console.WriteLine("\nList of commands:");
                Console.WriteLine("\n1 - book a Table.\n2 - Exit the Program.");
                Console.WriteLine("\nEnter the Command");

                //The "MENU" with option selections
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        int guestTable;
                        int guestSeat;
                        Console.Write("Which table do you want to book?: ");
                        guestTable = Convert.ToInt32(Console.ReadLine()) - 1;
                        if (tableSeats.Length <= guestTable || guestTable < 0)
                        {
                            Console.WriteLine("Thre's no such table!");
                            break;
                        }
                        Console.Write("How many seats do you want to book?: ");
                        guestSeat = Convert.ToInt32(Console.ReadLine());
                        if (tableSeats[guestTable] < guestSeat || guestSeat < 0)
                        {
                            Console.WriteLine("Insufficient amount!");
                            break;
                        }
                        tableSeats[guestTable] -= guestSeat;
                        break;
                    case 2:
                        isOpen = false;
                        Console.WriteLine("Closing the program. Good bye!");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
