using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using System.Threading.Tasks;
using Amora.Data;

namespace Amora.Models
{
        public static class SeedData

        {

            public static void Initialize(IServiceProvider serviceProvider)

            {

                using (var context = new AmoraContext(

                    serviceProvider.GetRequiredService<
                         DbContextOptions<AmoraContext>>()))

                {

                    // Cualquier (any) registros.

                    if (context.Animal.Any())

                    {
                        return;   // DB has been seeded
                    }


                    context.Animal.AddRange(

                        new Animal

                        {
                            Nombre = "Priscila",
                            Rasgos_Distintivos = "Blanca",
                            Peso = "350 kg",
                            Edad = "8 años",
                            Especie = "Vaca",
                            Sexo = "Femenino",
                            Fecha_Ingreso = DateTime.Parse("12-10-2022"),
                            Ultima_Desparasitacion = DateTime.Parse("15-10-2022"),
                            Tipo_vacuna = "Brucelosis",
                            Dosis = "Primera",
                            Fecha_Vacuna = DateTime.Parse("16-10-2022"),
                            Observaciones = "Ninguna"
                        },


                        new Animal

                        {
                            Nombre = "Hernan",
                            Rasgos_Distintivos = "Negro",
                            Peso = "500 kg",
                            Edad = "10 años",
                            Especie = "Vaca",
                            Sexo = "Masculino",
                            Fecha_Ingreso = DateTime.Parse("13-10-2022"),
                            Ultima_Desparasitacion = DateTime.Parse("18-10-2022"),
                            Tipo_vacuna = "IBR-BVD",
                            Dosis = "Primera",
                            Fecha_Vacuna = DateTime.Parse("20-10-2022"),
                            Observaciones = "Requiere un análisis a futuro"
                        },


                        new Animal

                        {
                            Nombre = "",
                            Rasgos_Distintivos = "Manchas Blancas",
                            Peso = "450 kg",
                            Edad = "9 años",
                            Especie = "Vaca",
                            Sexo = "Femenino",
                            Fecha_Ingreso = DateTime.Parse("16-10-2022"),
                            Ultima_Desparasitacion = DateTime.Parse("19-10-2022"),                        
                            Tipo_vacuna = "IBR-BVD",
                            Dosis = "Segunda",
                            Fecha_Vacuna = DateTime.Parse("20-10-2022"),
                            Observaciones = ""
                        },

                        new Animal
                        {
                            Nombre = "Ana",
                            Rasgos_Distintivos = "Negra",
                            Peso = "400 kg",
                            Edad = "10 años",
                            Especie = "Vaca",
                            Sexo = "Femenino",
                            Fecha_Ingreso = DateTime.Parse("21-10-2022"),
                            Ultima_Desparasitacion = DateTime.Parse("23-10-2022"),
                            Tipo_vacuna = "Brucelosis",
                            Dosis = "Primera",
                            Fecha_Vacuna = DateTime.Parse("24-10-2022"),
                            Observaciones = "Ninguna"
                        },

                        new Animal

                        {
                            Nombre = "",
                            Rasgos_Distintivos = "Manchas Negras",
                            Peso = "250 kg",
                            Edad = "5 años",
                            Especie = "Vaca",
                            Sexo = "Masculino",
                            Fecha_Ingreso = DateTime.Parse("22-10-2022"),
                            Ultima_Desparasitacion = DateTime.Parse("25-10-2022"),
                            Tipo_vacuna = "Brucelosis",
                            Dosis = "Primera",
                            Fecha_Vacuna = DateTime.Parse("26-10-2022"),
                            Observaciones = "Ninguna"
                        }



                    );


                    context.SaveChanges();

                }

            }

        }

}




