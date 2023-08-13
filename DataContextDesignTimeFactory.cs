using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Work_Tool
{
     public class DataContextDesignTimeFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

            // Aggiusta la stringa di connessione secondo le tue esigenze
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\user\\OneDrive\\Desktop\\DB\\Test_WorkTool.db"); 

            return new DataContext(optionsBuilder.Options);
        }
    }
}
