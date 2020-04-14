using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using System.ComponentModel;

namespace avance.Models
{
    public class PersonaModel : INotifyPropertyChanged
    {
        private int idPersona;
        private string nombre;
        private string apellido;
        private string correo;
        private string pais;
        private string ciudad;
        private DateTime fecha;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propiedad) {
            if (PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        [PrimaryKey,AutoIncrement]
        public int IdPersona
        {
            get
            {
                return idPersona;
            }

            set
            {
                if (idPersona != value) {
                    idPersona = value;
                    OnPropertyChanged("idPersona");
                }
               
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                if (nombre != value)
                {
                    nombre = value;
                    OnPropertyChanged("nombre");
                }
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                if (apellido != value)
                {
                    apellido = value;
                    OnPropertyChanged("apellido");
                }
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                if (correo != value)
                {
                    correo = value;
                    OnPropertyChanged("correo");
                }
            }
        }

        public string Pais
        {
            get
            {
                return pais;
            }

            set
            {
                if (pais != value)
                {
                    pais = value;
                    OnPropertyChanged("pais");
                }
            }
        }

        public string Ciudad
        {
            get
            {
                return ciudad;
            }

            set
            {
                if (ciudad != value)
                {
                    ciudad = value;
                    OnPropertyChanged("ciudad");
                }
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }

            set
            {
                if (fecha != value)
                {
                    fecha = value;
                    OnPropertyChanged("fecha");
                }
            }
        }
    }
}
