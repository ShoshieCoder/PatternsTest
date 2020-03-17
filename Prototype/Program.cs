using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>{
                new Employee (1,"Zrobavel", 55, 3000 ),
                new Employee (2, "Zrobavela", 25, 5000),
                new Employee (3, "Sahar", 28, 8000),
                new Employee (4, "Turgeman", 28, 8000)
            };

            List<Employee> cloneList = CloneList(empList);
            PrintList(cloneList);
            List<Employee> sortList = SortList(cloneList);
            PrintList(sortList);
        }

        static List<Employee> CloneList(List<Employee> empList)
        {
            List<Employee> empCloneList = new List<Employee>();
            foreach (Employee em in empList)
            {
                empCloneList.Add(em.Clone());
            }
            return empCloneList;
        }

        static List<Employee> SortList(List<Employee> empList)
        {
            int Count = 200; // empList.Count when not dubugging
            if (Count < 100)
                return empList.OrderBy(e => e.Id).ToList<Employee>();
            else if (Count <= 200)
                return empList.OrderBy(e => e.Name).ToList<Employee>();
            else if (Count >= 300)
                return empList.OrderBy(e => e.Salary).ToList<Employee>();
            else
            {
                Console.WriteLine("Couldn't sort");
                return null;
            }
                
        }

        static void PrintList(List<Employee> empList)
        {
            foreach (Employee e in empList)
            {
                e.Print();
            }
        }
    }
}
