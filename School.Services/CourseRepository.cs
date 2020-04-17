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
    public class CourseRepository
    {
        MyDatabase db = new MyDatabase();

        public IEnumerable<Course> GetAll()
        {
                return db.Courses.ToList();
        }

        public Course GetById(int? id)
        {
                return db.Courses.Find(id);
        }

        public void Insert(Course c)
        {
                db.Entry(c).State = EntityState.Added;
                db.SaveChanges();
        }

        public void Update(Course c)
        {
                db.Entry(c).State = EntityState.Modified;
                db.SaveChanges();
        }

        public void Delete(Course c)
        {
                db.Entry(c).State = EntityState.Deleted;
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
