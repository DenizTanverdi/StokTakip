using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLinq
{
    public class DAL
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public int LoginKontrol(User u)
        {
            var login = db.Users.FirstOrDefault(I => I.email == u.email && I.pasword == u.pasword);
            int ret = 0;
            if (login!=null)
            {
                ret = 1;
            }
            else
            {
                ret = -1;
            }

            return ret;

        }

        
    }
}
