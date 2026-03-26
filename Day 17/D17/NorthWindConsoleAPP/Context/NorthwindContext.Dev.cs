using Microsoft.EntityFrameworkCore;
using NorthWindConsoleAPP.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindConsoleAPP.Context
{
    partial class NorthwindContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasQueryFilter(P => P.Discontinued == false);
        }
    }
}
