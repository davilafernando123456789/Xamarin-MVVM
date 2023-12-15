using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Trigger.Interfaces
{
    public interface IConfigDataBase
    {
        string GetFullPath(string databaseFileName);
    }
}
