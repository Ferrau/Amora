using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Amora.Models
{
    public class Animal
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }


        [Display(Name = "Rasgos Distintivos"), StringLength(50)]
        public string Rasgos_Distintivos { get; set; }

        [StringLength(15)]
        public string Peso { get; set; }


        [StringLength(8)]
        public string Edad { get; set; }

        [StringLength(50)]
        public string Especie { get; set; }

        [StringLength(10)]
        public string Sexo { get; set; }


        [Display(Name = "Fecha de Ingreso"), DataType(DataType.Date)]
        public DateTime Fecha_Ingreso { get; set; }

        [Display(Name = "Última Desparasitación"), DataType(DataType.Date)]
        public DateTime Ultima_Desparasitacion { get; set; }



        [Display(Name = "Tipo de Vacuna"), StringLength(50)]
        public string Tipo_vacuna { get; set; }

        [StringLength(20)]
        public string Dosis { get; set; }


        [Display(Name = "Fecha de Vacunación"), DataType(DataType.Date)]
        public DateTime Fecha_Vacuna { get; set; }

        [StringLength(50)]
        public string Observaciones { get; set; }
    }
}
