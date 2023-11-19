using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class AdoNetCategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine("Ado.Net kullanılarak veritabanına eklendi...");
        }
    }
}
