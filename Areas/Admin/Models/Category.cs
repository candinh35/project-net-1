using Microsoft.Build.Framework;

namespace MyMvcProject.Areas.Admin.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<Product> Products { get; set;}
    }
}
