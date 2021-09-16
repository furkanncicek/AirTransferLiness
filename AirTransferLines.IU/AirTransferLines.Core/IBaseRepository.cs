using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core
{
   public interface IBaseRepository<T> where T:class
    {
        DbSet<T> Set();
        bool Update(T entity);
        bool Delete(T entity);
        T Find(int id);
        List<T> ListAll();
        bool Add(T entity);
        void Commit();
    }
}
