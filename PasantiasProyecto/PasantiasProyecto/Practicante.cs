using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasantiasProyecto
{
    class Practicante : Usuario
    {
        private int idPracticante;
        private DateTime fechaNacimiento;
        private int creditosAprobados;
        private string carrera;

        public int IdPracticante { get => idPracticante; set => idPracticante = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int CreditosAprobados { get => creditosAprobados; set => creditosAprobados = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public Practicante(int idPracticante, DateTime fechaNacimiento, int creditosAprobados, string carrera)
        {
            this.idPracticante = idPracticante;
            this.fechaNacimiento = fechaNacimiento;
            this.creditosAprobados = creditosAprobados;
            this.carrera = carrera;
        }

        public Practicante()
        {
        }

        public override string ToString()
        {
            return this.IdPracticante+" "+this.NombreUsuario+" "+this.CreditosAprobados;
        }
    }
}
