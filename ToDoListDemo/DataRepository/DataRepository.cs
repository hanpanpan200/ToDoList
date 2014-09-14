using IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class DataRepository:IDataRepository
    {

        #region IDataRepository 成员

        public bool Login(string argUserName,string argPwd)
        {
            return true;
        }

        #endregion
    }
}
