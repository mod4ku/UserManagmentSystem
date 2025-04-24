using System;

namespace UserManagmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var manager = new UserManager();
            manager.AddUser("test");
            Console.WriteLine(manager.RemoveUser("test")); // Должно вывести True
        }
       
    }
}
