using System.Collections.Generic;

namespace Curso_CSharp_Intermediario
{
    public class Construtor
    {
        public int Id;
        public string Name;
        public List<Order> Orders;
        

        public Construtor()
        {
            Orders = new List<Order>();
        }
        public Construtor(int id)
            : this()
        {
            this.Id = id;
        }

        public Construtor(int id, string name)
            : this(id)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
