using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Commencode;
using sqldbacess;

namespace Businesslogiclayer
{
   public class Buslogicl
    {
      private static  User UserDetail=null;
        public static bool UserLogin(Commencode.User _user )
        {
            try
            {
              UserDetail = DbAccess.validateuser(_user);
                if(UserDetail==null)
                {
                    return false;

                }
                else return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
