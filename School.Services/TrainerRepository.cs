using School.Database;
using School.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace School.Services
{
    public class TrainerRepository
    {
        MyDatabase db = new MyDatabase();

        public IEnumerable<Trainer> GetAll()
        {
                return db.Trainers.ToList();
        }

        public Trainer GetById(int? id)
        {
                return db.Trainers.Find(id);
        }

        public void Insert(Trainer t)
        {
                db.Entry(t).State = EntityState.Added;
                db.SaveChanges();
        }

        public void Update(Trainer t)
        {
                db.Entry(t).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(Trainer t)
        {
                db.Entry(t).State = EntityState.Deleted;
                db.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
