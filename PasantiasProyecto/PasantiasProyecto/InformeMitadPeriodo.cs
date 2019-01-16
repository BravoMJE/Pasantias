using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasantiasProyecto
{
    class InformeMitadPeriodo
    {
        private int idInformeMitadPeriodo;
        private Empresa empresa;
        private Practicante practicante;
        private string preparacionTecnica;
        private string capacidadAprendizaje;
        private Boolean trabajoEquipo;
        private Boolean creatividad;
        private Boolean adaptacion;
        private Boolean responsabilidad;
        private Boolean puntualidad;
        private List<ControlTutor> controlesTutorias;

        public int IdInformeMitadPeriodo { get => idInformeMitadPeriodo; set => idInformeMitadPeriodo = value; }
        public string PreparacionTecnica { get => preparacionTecnica; set => preparacionTecnica = value; }
        public string CapacidadAprendizaje { get => capacidadAprendizaje; set => capacidadAprendizaje = value; }
        public bool TrabajoEquipo { get => trabajoEquipo; set => trabajoEquipo = value; }
        public bool Creatividad { get => creatividad; set => creatividad = value; }
        public bool Adaptacion { get => adaptacion; set => adaptacion = value; }
        public bool Responsabilidad { get => responsabilidad; set => responsabilidad = value; }
        public bool Puntualidad { get => puntualidad; set => puntualidad = value; }
        internal Empresa Empresa { get => empresa; set => empresa = value; }
        internal Practicante Practicante { get => practicante; set => practicante = value; }
        internal List<ControlTutor> ControlesTutorias { get => controlesTutorias; set => controlesTutorias = value; }

        public InformeMitadPeriodo()
        {
        }

        public InformeMitadPeriodo(int idInformeMitadPeriodo, Empresa empresa, Practicante practicante, string preparacionTecnica, string capacidadAprendizaje, bool trabajoEquipo, bool creatividad, bool adaptacion, bool responsabilidad, bool puntualidad, List<ControlTutor> controlesTutorias)
        {
            this.idInformeMitadPeriodo = idInformeMitadPeriodo;
            this.empresa = empresa;
            this.practicante = practicante;
            this.preparacionTecnica = preparacionTecnica;
            this.capacidadAprendizaje = capacidadAprendizaje;
            this.trabajoEquipo = trabajoEquipo;
            this.creatividad = creatividad;
            this.adaptacion = adaptacion;
            this.responsabilidad = responsabilidad;
            this.puntualidad = puntualidad;
            this.controlesTutorias = controlesTutorias;
        }

        public override string ToString()
        {
            return this.IdInformeMitadPeriodo+" ";
        }
    }
}
