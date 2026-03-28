using System;
using System.Collections.Generic;
using System.Text;
using Business_Logic_Layer.Entities;
using Business_Logic_Layer.EntityManagers;

namespace Business_Logic_Layer.EntityLists
{
    public class TitleList : List<Title>
    {
        public (int, int, int) SaveChanges()
        {
            int Added = 0, Modified = 0, Deleted = 0;
            foreach (var item in this)
            {
                switch (item.State)
                {
                    case EntityState.Added: Added += TitleManager.Insert(item) ? 1 : 0; break;
                    case EntityState.Modified: Modified += TitleManager.Update(item) ? 1 : 0; break;
                    case EntityState.Deleted: Deleted += TitleManager.Delete(item.title_id) ? 1 : 0; break;
                }
                if (item.State != EntityState.Deleted)
                    item.State = EntityState.UnChanged;
            }
            this.RemoveAll(item => item.State == EntityState.Deleted);
            return (Added, Modified, Deleted);
        }
    }
}
