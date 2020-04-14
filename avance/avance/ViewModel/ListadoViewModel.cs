using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using avance;
using avance.Models;

namespace avance.ViewModel
{
   public class ListadoViewModel:PersonaModel
    {
        private ObservableCollection<PersonaModel> ListadoPersonas;

        public ListadoViewModel() {

        }
        

        public ObservableCollection<PersonaModel> ListadoPersonas1
        {
            get
            {
                if (ListadoPersonas==null) {
                    LlenarPersonas();
                }

                return ListadoPersonas;
            }

            set
            {
                ListadoPersonas = value;
            }
        }

        public void LlenarPersonas() {
            using (var contexto = new DataContext()) {
                ObservableCollection<PersonaModel> modelo = new ObservableCollection<PersonaModel>(contexto.Consultar());
                ListadoPersonas = modelo;
            }


           
        }
    }
}
