using System;

namespace Curso_CSharp_Intermediario
{
    public class Person2
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person2(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }

        public int Age
        {
            get 
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
            
    }

}
