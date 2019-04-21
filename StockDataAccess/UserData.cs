using StockModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockDataAccess
{
    //操作模板  using(StockContext db = new StockContext())
    public class UserData
    {
       public List<UserLoginView> GetUserLoginList()
        {
            using (StockContext db = new StockContext())
            {
                var temp = db.UserInfos.Select(c => new { c.UserID, c.UserPassword,c.IsAdmin });
                List<UserLoginView> userLogins = new List<UserLoginView>();
                foreach (var item in temp.ToList())
                {
                    UserLoginView newInfo = new UserLoginView
                    {
                        UserID = item.UserID,
                        UserPassword = item.UserPassword,
                        IsAdmin=item.IsAdmin
                    };
                    userLogins.Add(newInfo);
                }
                return userLogins;
            }
        }
    }
}
