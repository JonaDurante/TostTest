using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TostTest.App.Contexts
{
    public class TostTestContext : DbContext
    {
        public TostTestContext(DbContextOptions<TostTestContext> options) : base(options)
        {
                
        }
    }
}
