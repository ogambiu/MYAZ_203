using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_hafta_2
{
    public class Employee
    {
        public string firstName { get; set; } 
        public string lastName { get; set; }
        public int Id { get; set; }

        public Employee(string firstname, string lastname, int id)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.Id = id;
        }

        public override string ToString()
        {
            return $"{firstName,-20} {lastName,-20} {Id,15}";
            
        }
    }
}
