using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Entities
{
    public class EntityBase
    {
        public EntityState State 
        { 
            get;
            set
            {
                if (field == value) return;
                if (value != EntityState.Modified || field != EntityState.Added)
                    field = value;

            }
        } = EntityState.UnChanged;
    }
}
