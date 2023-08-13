using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work_Tool.Forms;

namespace Work_Tool
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        // Costruttore senza parametri
        public DataContext() { }

        public DbSet<Idea> Ideas => Set<Idea>();
        public DbSet<Topic> Topic => Set<Topic>();
        public DbSet<ToDoItem> ToDoItem => Set<ToDoItem>();
        public DbSet<Ptompt_Template> Template => Set<Ptompt_Template>();
    }
}
