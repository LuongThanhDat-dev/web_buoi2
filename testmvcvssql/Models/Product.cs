using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testmvcvssql.Models;
    [Table("SanPham")]
public class Product{
    [Key]
    public int id { get; set; }
    [Column("ProductName",TypeName ="nvarchar",Order = 1)]
    public string Name { get; set; } = string.Empty ;
    [Column(TypeName ="int")]
    public int Quantity { get; set; }
    [Column(TypeName ="decimal")]
    public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public int CatId { get; set; }
        [ForeignKey("CatId")]

        public Category? Cate { get; set; }


}