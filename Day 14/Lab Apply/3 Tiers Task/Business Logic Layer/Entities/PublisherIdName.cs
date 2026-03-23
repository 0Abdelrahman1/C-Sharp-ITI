using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Logic_Layer.Entities
{
    public class PublisherIdName : EntityBase
    {
        public required string pub_id { get; set; } //[pub_id][char](4) NOT NULL,
        public string? pub_name { get; set; }       //[pub_name] [varchar] (40) NULL,
    }
}
