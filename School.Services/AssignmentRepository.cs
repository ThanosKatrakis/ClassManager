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
    public class AssignmentRepository
    {
        MyDatabase db = new MyDatabase();

        public IEnumerable<Assignment> GetAll()
        {
                return db.Assignments.ToList();
        }

        public Assignment GetById(int? id)
        {
                return db.Assignments.Find(id);
        }

        public void Insert(Assignment a)
        {
                db.Entry(a).State = EntityState.Added;
                db.SaveChanges();
        }

        public void Update(Assignment a)
        {
                db.Entry(a).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(Assignment a)
        {
                db.Entry(a).State = EntityState.Deleted;
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
