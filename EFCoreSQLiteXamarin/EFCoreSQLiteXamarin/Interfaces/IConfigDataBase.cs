using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreSQLiteXamarin.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
