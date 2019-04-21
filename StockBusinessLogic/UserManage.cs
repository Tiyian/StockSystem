using StockDataAccess;
using StockModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockBusinessLogic
{
    public class UserManage
    {
        UserData dal;
        public UserManage()
        {
            this.dal = new UserData();
        }
        public bool IsAdmin (UserLoginView userLogin)
        {
            foreach(var item in dal.GetUserLoginList())
            {
                if(userLogin.UserID==item.UserID)
                {
                    return item.IsAdmin;
                }
            }
            return false;
        }
    }
}
