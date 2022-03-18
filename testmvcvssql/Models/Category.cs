using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace testmvcvssql.Models;

    [Table("DanhMuc")]
public class Category {
    [Key]
    public int id { get; set; }
    [Column(TypeName ="nvarchar")]
    public string Name { get; set; } = string.Empty;
    public List<Product>? Products { get; set; }
}