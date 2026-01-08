using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Program
    {
        static void Main(string[] args) 
        {
            List<User> users = new List<User>();

            Console.WriteLine("Enter Number Of Users To Added:");
            int numOfUsers = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numOfUsers; i++) { 
                
                User user = new User();
                Console.WriteLine($"Enter User{i} Details");

                Console.WriteLine("Enter user name:");
                user.name = Console.ReadLine(); 

                Console.WriteLine("Enter user id:");
                user.id = Convert.ToInt32(Console.ReadLine()) ; 

                Console.WriteLine("Enter user Gender:");
                user.gender = Console.ReadLine(); 

                users.Add(user);
            
            }

            for (int i = 0; i < numOfUsers; i++)
            {
                Console.WriteLine($"User{i} Id:{users[i].id} Name:{users[i].name} Gender:{users[i].gender}");
            }

            //foreach (User user in users) {
            //    Console.WriteLine($"User  Id:{user.id} Name:{user.name} Gender:{user.gender}");
            //}

        }
    }
}
