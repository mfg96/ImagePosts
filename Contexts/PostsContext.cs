using ImagePosts.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagePosts.Contexts
{
    public class PostsContext:DbContext
    {
        public PostsContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<ImageModel> ImagePost { get; set; }
    }
}
