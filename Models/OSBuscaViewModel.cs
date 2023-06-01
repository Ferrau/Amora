using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Amora.Models
{
    public class OSBuscaViewModel
    {
        
        public List<Animal> Animals { get; set; }
        public SelectList Tipo_vacuna { get; set; }
        public string OSAnimal { get; set; }
        public string SearchString { get; set; }
    }
}
