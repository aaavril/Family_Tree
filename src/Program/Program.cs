using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Node<int> n1 = new Node<int>(1);
            // Node<int> n2 = new Node<int>(2);
            // Node<int> n3 = new Node<int>(3);
            // Node<int> n4 = new Node<int>(4);
            // Node<int> n5 = new Node<int>(5);
            // Node<int> n6 = new Node<int>(6);
            // Node<int> n7 = new Node<int>(7);
            //
            // n1.AddChildren(n2);
            // n1.AddChildren(n3);
            //
            // n2.AddChildren(n4);
            // n2.AddChildren(n5);
            //
            // n3.AddChildren(n6);
            // n3.AddChildren(n7);
            //
            // // visitar el árbol aquí
            // SumVisitor visitor = new SumVisitor();
            // n1.Accept(visitor);
            // Console.WriteLine(visitor.Sum);
            
            Node<Person> n1 = new Node<Person>(new Person(50, "Carlos"));
            Node<Person>n2 = new Node<Person>(new Person(30, "Juan"));
            Node<Person> n3 = new Node<Person>(new Person(30, "Paco"));
            Node<Person> n4 = new Node<Person>(new Person(30, "Pedro"));
            Node<Person> n5 = new Node<Person>(new Person(2, "Juancito"));
            Node<Person> n6 = new Node<Person>(new Person(3, "Paquito"));
            Node<Person> n7 = new Node<Person>(new Person(1, "Paquín"));
            
            n1.AddChildren(n2);
            n1.AddChildren(n3);
            n1.AddChildren(n4);
            
            n2.AddChildren(n5);
            
            n3.AddChildren(n6);
            n3.AddChildren(n7);
            
            SumAgeVisitor visitor = new SumAgeVisitor();
            n1.Accept(visitor);
            Console.WriteLine(visitor.Sum);
        }
    }
}
