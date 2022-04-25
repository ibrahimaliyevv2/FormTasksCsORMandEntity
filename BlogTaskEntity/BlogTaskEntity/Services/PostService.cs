using BlogTaskEntity.DAL;
using BlogTaskEntity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogTaskEntity.Services
{
    public class PostService
    {
        TaskDbContext taskDbContext = new TaskDbContext();
        public void AddPost(string title, string content)
        {
            Post post = new Post
            {
                Title = title,
                Content = content
            };

            taskDbContext.Posts.Add(post);
            taskDbContext.SaveChanges();
        }

        public void EditPostTitle(int id, string title)
        {
            taskDbContext.Posts.Where(x => x.Id == id).FirstOrDefault().Title = title;
            taskDbContext.SaveChanges();
        }
        
        public Post GetPostById(int id)
        {
            return taskDbContext.Posts.Where(x=>x.Id==id).FirstOrDefault();
        }

        public List<Post> GetAllPosts()
        {
            return taskDbContext.Posts.ToList();
        }

        public void DeletePost(int id)
        {
            var deleteIt = taskDbContext.Posts.Where(x => x.Id == id).FirstOrDefault();
            taskDbContext.Posts.Remove(deleteIt);
            taskDbContext.SaveChanges();
        }
    }
}
