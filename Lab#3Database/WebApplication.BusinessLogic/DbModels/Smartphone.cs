using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.BusinessLogic.DbModels
{
    public class Smartphone
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string PicturePath { get; set; }

        public int Price { get; set; }

        [Required]
        public string OperatingSystem { get; set; }

        public string Camera { get; set; }

        public string Display { get; set; }

        public string CPU { get; set; }

        public string Memory { get; set; }

        public string Battery { get; set; }

        public string Dimension { get; set; }

        public string Weight { get; set; }

        public string Port { get; set; }

    }
}
