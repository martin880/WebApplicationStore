using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationStore.Models;

namespace WebApplicationStore.Infrastructure
{
    public class WebApplicationStoreContext : DbContext
    {
        public WebApplicationStoreContext(DbContextOptions<WebApplicationStoreContext>options)
            : base(options)
        {
           
        }

        public DbSet<Page> Pages { get; set; }
    }
}
