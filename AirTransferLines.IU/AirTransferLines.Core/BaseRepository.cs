
using AirTransferLines.Dall;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTransferLines.Core
{
   public class BaseRepository<T>:IBaseRepository<T> where T:class
    {
        AirTransferLinessDBEntities db = new AirTransferLinessDBEntities();
        
        public DbSet<T> Set()
        {
            return db.Set<T>();
        }
        public bool Update(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Delete(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public T Find(int id)
        {
            return Set().Find(id);
        }
        public List<T> ListAll()
        {
            return Set().ToList();
        }
        public bool Add(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Added;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Commit()
        {
                db.SaveChanges();
            

        }
    }
}

