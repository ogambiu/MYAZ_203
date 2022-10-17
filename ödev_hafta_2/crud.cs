using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev_hafta_2
{
    public class crud
    {
        List<Employee> employees;
        public crud()
        {
            employees = new List<Employee>();
        }
        public void createEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public void ReadList()
        {
            foreach (var item in employees)
                Console.WriteLine(item);
        }

        public void delEmployee(int id)
        {
            var itemcount = employees.Count;
            foreach (var item in employees)
                if (item.Id == id) { employees.Remove(item); ReadList(); return; }

            if (itemcount == employees.Count)
            {
                Console.WriteLine("HATA");
                return;
            }
        }
    }
}
