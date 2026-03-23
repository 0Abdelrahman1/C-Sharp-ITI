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
                    case EntityState.Added:
                        Added += TitleManager.InsertTitleRow(
                        item.title_id, item.title, item.type, item.pub_id, item.price, item.advance, item.royalty, item.ytd_sales, item.notes, item.pubdate) ? 1 : 0; break;
                    case EntityState.Modified:
                        Modified += TitleManager.UpdateTitleRow(
                        item.title_id, item.title, item.type, item.pub_id, item.price, item.advance, item.royalty, item.ytd_sales, item.notes, item.pubdate) ? 1 : 0; break;
                    case EntityState.Deleted: Deleted += TitleManager.DeleteTitleRow(item.title_id) ? 1 : 0; break;
                }
                if (item.State != EntityState.Deleted)
                    item.State = EntityState.UnChanged;
            }
            this.RemoveAll(item => item.State == EntityState.Deleted);
            return (Added, Modified, Deleted);
        }
    }
}
