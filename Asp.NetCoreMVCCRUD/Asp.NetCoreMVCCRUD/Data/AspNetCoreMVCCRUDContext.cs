using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp.NetCoreMVCCRUD.Models;

namespace Asp.NetCoreMVCCRUD.Data
{
    public class AspNetCoreMVCCRUDContext : DbContext
    {
        public AspNetCoreMVCCRUDContext (DbContextOptions<AspNetCoreMVCCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<Asp.NetCoreMVCCRUD.Models.Categoria> Categoria { get; set; }
    }
}
