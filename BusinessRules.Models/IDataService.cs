using System;
using System.Collections.Generic;
using System.Text;

namespace app_models
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}
