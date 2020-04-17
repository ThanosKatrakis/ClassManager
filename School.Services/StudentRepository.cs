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
    public class StudentRepository
    {
        MyDatabase db = new MyDatabase();

        public IEnumerable<Student> GetAll()
        {
                return db.Students.ToList();
        }

        public Student GetById(int? id)
        {
                return db.Students.Find(id);
        }

        public void Insert(Student s)
        {
                db.Entry(s).State = EntityState.Added;
                db.SaveChanges();
        }

        public void Update(Student s)
        {
                db.Entry(s).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(Student s)
        {
                db.Entry(s).State = EntityState.Deleted;
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
