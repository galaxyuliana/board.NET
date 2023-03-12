using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BoardNet.Models;

namespace BoardNet.Data
{
    public class BoardNetContext : DbContext
    {
        public BoardNetContext (DbContextOptions<BoardNetContext> options)
            : base(options)
        {
        }

        public DbSet<BoardNet.Models.User> User { get; set; } = default!;
    }
}
