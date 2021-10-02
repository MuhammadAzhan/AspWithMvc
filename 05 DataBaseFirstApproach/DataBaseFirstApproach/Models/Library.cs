using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DataBaseFirstApproach.Models
{
    [Table("tb_info")]
    public class Library
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
    }
}