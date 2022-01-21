using System;

namespace LinkedListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Linked list Assignment-----");
            LinkedList list = new LinkedList();
            //UseCase2
            Console.WriteLine("Ther");
            list.Add(56);
            list.Add(30);
            list.Add(70);
            //Usecase 4
            Console.WriteLine("\n The New data 30 is inserted into second position");
            list.InsertAtParticularPosition(2,30);
            Console.WriteLine("\n The updated Linked list is:");
            list.Display();
            //Usecase 5
            list.RemoveFirstNode();
            //Usecase 6
            list.RemoveLastNode();
            Console.WriteLine("\n \n The Linked list after the deletion of first and last node is :");
            list.Display();
            //Usecase 7
            list.Search(70);
          //  list.Display();
            Console.ReadKey();
        }
    }
}

