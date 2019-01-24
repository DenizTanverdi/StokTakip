using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEntity
{
    public class Class1
    {
        StokTakipDEntities stk = new StokTakipDEntities();
      void test()
        {
            Users users = new Users();
            users.email = "dd@gg.com";
            users.pasword = "123123";
            users.isLogin = true;
            stk.Users.Add(users);
            stk.SaveChanges();
        }
    }
}
