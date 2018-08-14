using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFirstMvc.Models
{
    public class MyQuer
    {
    }
    [Table("SecondClass")]
    public class ProductDb
    {
        [Key] //主键 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Key] //主键 
        public int ID1 { get; set; }
    }
    public class MyConnection : DbContext
    {
       // public DbSet<ProductDb> Products { set; get;}
    }

}