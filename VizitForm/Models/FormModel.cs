using Microsoft.EntityFrameworkCore;
using System;
using VizitForm.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VizitForm.Models
{
    public class FormModel : DbContext
    {
        public FormModel(DbContextOptions<FormModel> options) : base(options)
        {

        }

        public DbSet<FormDataModel> Form { get; set; }
        public DbSet<RegisterDataModel> Randevu { get; set; }
        public DbSet<FormTakipDataModel> TakipForm { get; set; }
    }
}
