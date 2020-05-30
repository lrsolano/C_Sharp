using System;

namespace Curso_CSharp_Intermediario
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person2(new DateTime(1982, 1, 1););
            Console.WriteLine(person.Age);
            

        }

        static void Aula1()
        {
            var p = Person.Parse("Leonardo");
            p.Introduce("Larissa");

            var custumer = new Construtor();
            custumer.Id = 1;
            custumer.Name = "leonardo";

            var order = new Order();
            custumer.Orders.Add(order);

            Console.WriteLine(custumer.Id);
            Console.WriteLine(custumer.Name);
        }

        static void UserPoint()
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
        }
    }

}
