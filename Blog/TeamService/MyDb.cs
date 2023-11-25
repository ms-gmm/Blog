using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamService.Models;

namespace TeamService
{
    public class MyDb : DbContext
    {

        public MyDb(DbContextOptions option) : base(option)
        {

        }
        public DbSet<Team> Team { get; set; }

        public void Configure(EntityTypeBuilder<Team> bulider)
        {

        }
    }
}
