using System;
using System.Collections;
using System.Linq;

namespace Linq_với_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nhanvien = new ArrayList()
            {
                new Staff { Id = 1, Name = "Nam", Age = 24 },
                new Staff{ Id = 2, Name = "Kiên", Age = 21 },
                new Staff{ Id = 3, Name = "Việt", Age = 21 },
                new Staff{ Id = 4, Name = "Hằng", Age = 23 },
                new Staff{ Id = 5, Name = "Tiến", Age = 24 }

            };

          

            var newArrayList = nhanvien.OfType<Staff>(); 
            
            var Search = from name in newArrayList
                         where (name.Age < 24)
                         select name;

            var sapxep = from name in newArrayList
                         orderby name.Name
                         select name;

            Console.WriteLine("Danh sach nguoi co tuoi nho hon 24:");

            foreach (var item in Search)
            {
                Console.WriteLine("ID :" + item.Id + " Name : " + item.Name + " Age : " + item.Age);
            }
            Console.WriteLine("Sap xep theo ten :");
            foreach (var item in sapxep)
            {
                Console.WriteLine("ID :" + item.Id + " Name : " + item.Name + " Age : " + item.Age);
            }
        }
    }
}
