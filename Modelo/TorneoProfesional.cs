using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class TorneoProfesional : Torneo
    {
        //Propiedades publicas de la clase Torneo Profesional
        public int Premio { get => _premio; set => _premio = value; }
        public string Ubicacion { get => _ubicacion; set => _ubicacion = value; }

        //Atributos de la clase Torneo Profesional
        int _premio;
        string _ubicacion;
    }
}
