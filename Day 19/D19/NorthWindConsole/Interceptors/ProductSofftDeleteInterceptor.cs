using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NorthWindConsole.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindConsole.Interceptors
{
    internal class ProductSofftDeleteInterceptor:SaveChangesInterceptor
    {


        public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
        {
            if (eventData != null)
            {
                var Entities = eventData.Context.ChangeTracker.Entries<Product>()
                                                .Where(E => E.State == EntityState.Deleted);


                foreach (var E in Entities)
                {
                    E.State = EntityState.Modified;
                    E.Entity.Discontinued = true; ///SoftDelete
                }


            }
            return base.SavingChanges(eventData, result);
        }

    }
}
