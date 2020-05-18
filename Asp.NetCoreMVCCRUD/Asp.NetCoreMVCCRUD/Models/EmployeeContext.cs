using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreMVCCRUD.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {
                
        }
    }
}
