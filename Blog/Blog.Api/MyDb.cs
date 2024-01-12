using Blog.Application.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Api
{
    public class MyDb : DbContext
    {
        public MyDb(DbContextOptions option) : base(option)
        {

        }
        public DbSet<UserDto> User { get; set; }
        public DbSet<ArticleDto> Article { get; set; }

    }
}
