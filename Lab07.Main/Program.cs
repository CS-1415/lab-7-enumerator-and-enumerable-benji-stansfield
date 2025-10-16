using System;

namespace Lab07.Main;

public class Program
{
    static void Main()
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.Write(@"
        LIST MENU
        a - add item to the front of the list
        b - add item to the back of the list
        p - print the current list
        q - exit the program
        ");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.A:
                    Console.Write("What would you like to add?: ");
                    int frontValue = Convert.ToInt32(Console.ReadLine());
                    list.AddFirst(frontValue);
                    break;

                case ConsoleKey.B:
                    Console.Write("What would you like to add?: ");
                    int backValue = Convert.ToInt32(Console.ReadLine());
                    list.AddLast(backValue);
                    break;

                case ConsoleKey.P:
                    foreach (var value in list)
                        Console.WriteLine($"{value}");
                    break;

                case ConsoleKey.Q:
                    running = false;
                    break;
            }
        }
    }
}
