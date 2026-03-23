using Business_Logic_Layer.Entities;
using Business_Logic_Layer.EntityLists;
using Data_Access_Layer;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static Azure.Core.HttpHeader;

namespace Business_Logic_Layer.EntityManagers
{
    public static class TitleManager
    {
        private static DbManager Manager { get; set; } = new();
        public static TitleList SelectAllTitles()
        {
            try
            {
                return Manager.ExecuteDataTable("SelectAllTitles").ToTitleList();
            }
            catch { return new(); }
            finally { }
        }

        public static bool UpdateTitleRow(string title_id, string title, string type, string? pub_id, decimal? price, decimal? advance, int? royalty, int? ytd_sales, string? notes, DateTime pubdate)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@title_id"] = title_id,
                    ["@title"] = title,
                    ["@type"] = type,
                    ["@pub_id"] = pub_id,
                    ["@price"] = price,
                    ["@advance"] = advance,
                    ["@royalty"] = royalty,
                    ["@ytd_sales"] = ytd_sales,
                    ["@notes"] = notes,
                    ["@pubdate"] = pubdate
                };
                return Manager.ExecuteNonQuery("UpdateTitleRow", Parameters) > 0;
            }
            catch { return false; }
            finally { }
        }
        public static bool InsertTitleRow(string title_id, string title, string type, string? pub_id, decimal? price, decimal? advance, int? royalty, int? ytd_sales, string? notes, DateTime pubdate)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@title_id"] = title_id,
                    ["@title"] = title,
                    ["@type"] = type,
                    ["@pub_id"] = pub_id,
                    ["@price"] = price,
                    ["@advance"] = advance,
                    ["@royalty"] = royalty,
                    ["@ytd_sales"] = ytd_sales,
                    ["@notes"] = notes,
                    ["@pubdate"] = pubdate
                };
                return Manager.ExecuteNonQuery("InsertTitleRow", Parameters) > 0;
            }
            catch { return false; }
            finally { }
        }
        public static bool DeleteTitleRow(string title_id)
        {
            try
            {
                Dictionary<string, object> Parameters = new()
                {
                    ["@title_id"] = title_id
                };
                return Manager.ExecuteNonQuery("DeleteTitleRow", Parameters) > 0;
            }
            catch { return false; }
            finally { }
        }
        internal static TitleList ToTitleList(this DataTable dt)
        {
            try
            {
                TitleList titles = new TitleList();
                foreach (DataRow row in dt.Rows)
                    titles.Add(row.ToTitle());
                return titles;
            }
            catch { return new(); }
            finally { }
        }
        internal static Title ToTitle(this DataRow row)
        {
            Title title = new() { title_id = "_", title = "_", type = "_", pubdate = DateTime.Now};
            try
            {
                title.title_id = row.Field<string>("title_id");
                title.title = row.Field<string>("title");
                title.type = row.Field<string>("type");
                title.pub_id = row.Field<string?>("pub_id");
                title.price = row.Field<decimal?>("price");
                title.advance = row.Field<decimal?>("advance");
                title.royalty = row.Field<int?>("royalty");
                title.ytd_sales = row.Field<int?>("ytd_sales");
                title.notes = row.Field<string?>("notes");
                title.pubdate = row.Field<DateTime>("pubdate");
                
                title.State = EntityState.UnChanged;
                return title;
            }
            catch { return title; }
            finally { }
        }
    }
}
