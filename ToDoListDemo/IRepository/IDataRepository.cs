using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace IRepository
{
    public interface IDataRepository
    {
        bool Login(string argUserName, string argPwd);
    }
}
