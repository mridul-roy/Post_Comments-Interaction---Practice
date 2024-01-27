using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PostRepo : Repo, IRepo<Post, int, Post>
    {
        public Post Create(Post obj)
        {
            db.Posts.Add(obj);
            if(db.SaveChanges()>0) return obj; 
            return null;
        }

        public bool Delete(int id)
        {
            var expost = Read(id);
            db.Posts.Remove(expost);
            return db.SaveChanges() > 0;
        }

        public List<Post> Read()
        {
            return db.Posts.ToList();
        }

        public Post Read(int id)
        {
            return db.Posts.Find(id);
        }

        public Post Update(Post obj)
        {
            var expost = Read(obj.Id);
            db.Entry(expost).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0) return obj;
            return null;
        }
    }
}
