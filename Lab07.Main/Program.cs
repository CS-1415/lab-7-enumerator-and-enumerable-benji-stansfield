using System;

namespace Lab07.Main;

public class Program
{
    static void Main()
    {
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();

        while (true)
        {
            Console.Clear();
            Console.Write(@"
        LIST MENU
        a - add item to the front of the list
        b - add item to the back of the list
        p - print the current list
        q - exit the program");
        }
    }
}
