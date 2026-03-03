using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones.Clases
{
    public class Maquinaria
    {
       
        public int CodigoInventario { get; set; }
        public string Nombre { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int AnioFabricacion { get; set; }
        public string Estado { get; set; } 


        public Maquinaria()
        {
        }   
        public Maquinaria(int codigo, string nombre, string modelo,
                          string marca, int anio, string estado)
        {
            CodigoInventario = codigo;
            Nombre = nombre;
            Modelo = modelo;
            Marca = marca;
            AnioFabricacion = anio;
            Estado = estado;
        }

      
        public string ObtenerResumen()
        {
            return $"{Nombre} - {Marca} {Modelo} ({AnioFabricacion}) | Estado: {Estado}";
        }
    }
}
