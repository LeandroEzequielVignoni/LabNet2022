using EntityFramework.Data;
using EntityFramework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Logic
{
    public class SuppliersLogic : BaseLogic, ILogic<Suppliers>
    {
        

        public SuppliersLogic()
        {
            
        }

        public List<Suppliers> GetAll()
        {

            return _context.Suppliers.ToList();


        }
    }
}
