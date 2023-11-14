using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Rango
    {
        //Propiedades publicas de la clase Rango
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Escala { get => _escala; set => _escala = value; }

        //Constructor de la clase Rango
        public Rango(string nombre, int escala)
        {
            _nombre = nombre;
            _escala = escala;
        }
        // Método para obtener una representación legible del rango
        public override string ToString()
        {
            return Nombre; // Retorna el Rango del jugador
        }
        //Atributos privados de la clase Rango
        private string _nombre;
        private int _escala;
    }
}
