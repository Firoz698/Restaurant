using Microsoft.EntityFrameworkCore;
using ResturenModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResturentInfrastructure
{
    public class ResturentDataBase : DbContext
    {
        public ResturentDataBase(DbContextOptions<ResturentDataBase> options) : base(options){}
        public DbSet<Account> Account { get; set; }
        
    }
}
