using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace VizitForm.Models
{
    public class RegisterDataModel
    {
        [Key]
        public int id { get; set; }
        public int Kimlik { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Mail { get; set; }

        [DataType(DataType.Date)]
        public DateTime DogumTarihi { get; set; }

        public string Cinsiyet { get; set; }

    }
}
