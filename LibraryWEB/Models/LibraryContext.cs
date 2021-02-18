using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryWEB.Models
{
    public class LibraryContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentText> CommentText { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }

        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options) {}
    }
}
