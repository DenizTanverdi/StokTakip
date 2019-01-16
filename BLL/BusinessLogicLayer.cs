using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessLogicLayer
    {
        DataAccessLayer dal;
        public BusinessLogicLayer()
        {
            dal = new DataAccessLayer();
        }
        public int LoginKontrol(string email, string password)
        {
            int ret = 0;
            Users u = new Users();
           // bool kontrol = EmailKontrol(email);
            bool k = !(string.IsNullOrEmpty(password));
            if ( k)
            {
                u.email = email;
                u.pasword = password;
                ret = dal.LoginKontrol(u);
            }
            else
            {
                ret = -1;
            }

            return ret;
        }
    }
}
