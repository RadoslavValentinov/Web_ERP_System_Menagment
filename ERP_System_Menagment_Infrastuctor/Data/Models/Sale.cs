using System.ComponentModel.DataAnnotations;

namespace ERP_System_Menagment_Infrastuctor.Data.Models
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }

        public DateTime SellTime { get; set; }

        public List<Products> Products { get; set; } = new List<Products>();

        public string UsercCreate { get; set; } = null!;

    }
}
