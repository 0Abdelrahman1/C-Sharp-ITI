using Business_Logic_Layer.Entities;
using Business_Logic_Layer.EntityLists;
using Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Business_Logic_Layer.EntityManagers
{
    public static class PublisherManager
    {
        private static DbManager Manager { get; set; } = new();
        public static PublisherIdNameList SelectAllPublishersIdName()
        {
            try
            {
                return Manager.ExecuteDataTable("SelectAllPublishersIdName").ToPublisherIdNameList();
            }
            catch { return new(); }
            finally { }
        }
        internal static PublisherIdNameList ToPublisherIdNameList(this DataTable dt)
        {
            try
            {
                PublisherIdNameList publishersIdName = new();
                foreach (DataRow row in dt.Rows)
                    publishersIdName.Add(row.ToPublisherIdName());
                return publishersIdName;
            }
            catch { return new(); }
            finally { }
        }
        internal static PublisherIdName ToPublisherIdName(this DataRow row)
        {
            PublisherIdName publisherIdName = new() { pub_id = "_" };
            try
            {
                publisherIdName.pub_id = row.Field<string>("pub_id");
                publisherIdName.pub_name = row.Field<string?>("pub_name");

                publisherIdName.State = EntityState.UnChanged;
                return publisherIdName;
            }
            catch { return publisherIdName; }
            finally { }
        }
    }
}
