using RestWithASP_NET5.Model.Base;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestWithASP_NET5.Model
{
    [Table("Books")]
    public class Books : BaseEntity
    {
        [Column("author")]
        public string Author { get; set; }
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
        [Column("price")]
        public Decimal Price { get; set; }
        [Column("title")]
        public string title { get; set; }
    }
}
