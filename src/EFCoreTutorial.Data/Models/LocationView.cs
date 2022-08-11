using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreTutorial.Data.Models
{
    public class LocationView
    {
        public int Id { get; set; }
        [Required]

        public string Name { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        public int MyProperty { get; set; }

    }
}

