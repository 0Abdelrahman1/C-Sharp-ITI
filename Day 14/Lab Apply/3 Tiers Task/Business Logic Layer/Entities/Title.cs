using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Entities
{
    public class Title : EntityBase
    {
		public Title() => State = EntityState.Added;
		public required string title_id { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[title_id][dbo].[tid] NOT NULL, // [tid] = varchar(6), NOT NULL
        public required string title { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[title] [varchar] (80) NOT NULL,
		public required string type { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[type] [char](12) NOT NULL,
		public string? pub_id { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[pub_id] [char](4) NULL,
		public decimal? price { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[price][money] NULL,
		public decimal? advance { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[advance][money] NULL,
		public int? royalty { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[royalty][int] NULL,
		public int? ytd_sales { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[ytd_sales][int] NULL,
		public string? notes { get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[notes][varchar] (200) NULL,
		public required DateTime pubdate {  get; set { if (field == value) return; field = value; State = EntityState.Modified; } } //[pubdate][datetime] NOT NULL, 

        public override string ToString() => $"Title [ID: {title_id}, Name: {title}, Type: {type}, Publisher: {pub_id}, Price: {price}, Advance: {advance}, Royalty: {royalty}, YTD Sales: {ytd_sales}, Notes: {notes}, Published: {pubdate:yyyy-MM-dd}, State: {State}]";
    }
}
