using System;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Leonardo Ribeiro ";
            Console.WriteLine("Trim: '{0}'",fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);

            Console.WriteLine("New Name: " + fullName.Replace("Leonardo", "Ariberto"));



            if (string.IsNullOrEmpty(null))
            {
                Console.WriteLine("Vazio");
            }

            if(string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalido");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));


        }
    }
}
