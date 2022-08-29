using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstCleanCode.Entity.Models
{
    // Table[("Urunler")] -> EF tablomuzu bu isimde oluşturacak
    public class Product
    {

        [Key] // birincil anahtar oldugunu söylüyoruz
        public int ProductID { get; set; }

        [Required] // Mecburi Alan
        [StringLength(50)] //Alan Uzunlugunu Belirtiyoruz
        public string ProductName { get; set; }
        public int ProductCode { get; set; }

        [Column(TypeName = "money")] //SQL VERİ TABANINDAKİ TİPİNİ BELİRTİYORUZ
        public decimal ProductPrice { get; set; }
        public string ProductDescription { get; set; }
        public bool ProductStatus { get; set; }


        

    }
}
