#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Notepad.Models;

namespace Notepad.Data
{
    public class NotepadContext : DbContext
    {
        public NotepadContext (DbContextOptions<NotepadContext> options)
            : base(options)
        {
        }

        public DbSet<Notepad.Models.User> User { get; set; }

        public DbSet<Notepad.Models.Note> Note { get; set; }
    }
}
