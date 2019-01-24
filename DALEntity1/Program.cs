using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity1
{
    class Program
    {
        static void Main(string[] args)
        {
            StokTakipDEntities stk = new StokTakipDEntities();
            Users users = new Users();
            users.email = "dd@gg.com";
            users.pasword = "123123";
            users.isLogin = true;
            stk.Users.Add(users);
            stk.SaveChanges();
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
