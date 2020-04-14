using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using avance.Models;
using avance;

namespace avance.ViewModel
{
   public class PersonaViewModel:PersonaModel
    {
        public ICommand Guardar { get; private set; }
        public ICommand Modificar { get; private set; }
        public ICommand Eliminar { get; private set; }
        public ICommand Nuevo { get; private set; }
        
        public PersonaViewModel() {
            Nuevo = new Command(() => {

                Nombre = string.Empty;
                Apellido = string.Empty;
                Ciudad = string.Empty;
                Correo = string.Empty;
                Fecha = DateTime.Now;
                Pais = string.Empty;

            }
          );


            Guardar = new Command(() => {
                PersonaModel modelo = new PersonaModel() {
                    Nombre=Nombre,
                    Apellido=Apellido,
                    Ciudad=Ciudad,
                    Correo=Correo,
                    Fecha=Fecha,
                    Pais=Pais
                };

                using (var contexto=new DataContext()) {
                    contexto.Insertar(modelo);
                }
            }
             );
            Modificar = new Command(() => {
                PersonaModel modelo = new PersonaModel()
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Ciudad = Ciudad,
                    Correo = Correo,
                    Fecha = Fecha,
                    Pais = Pais,
                    IdPersona = IdPersona
                };

                using (var contexto = new DataContext())
                {
                    contexto.Actualizar(modelo);
                }
            }
            );

            Eliminar = new Command(() => {
                PersonaModel modelo = new PersonaModel()
                {
                    Nombre = Nombre,
                    Apellido = Apellido,
                    Ciudad = Ciudad,
                    Correo = Correo,
                    Fecha = Fecha,
                    Pais = Pais,
                    IdPersona = IdPersona
                };

                using (var contexto = new DataContext())
                {
                    contexto.Eliminar(modelo);
                }
            }
           );

           
        }
    }
}
