using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Logic
{
    public interface ILogic<T>
    {
        List<T> GetAll();

        


    }
}
