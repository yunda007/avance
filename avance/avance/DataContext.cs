using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;
using Xamarin.Forms;
using System.IO;
using avance.Models;

namespace avance
{
    public class DataContext : IDisposable
    {
        private SQLiteConnection cnn;

        public DataContext() {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "persona.db3"));
            cnn.CreateTable<PersonaModel>();

        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(PersonaModel modelo) {
            cnn.Insert(modelo);
        }
        public void Actualizar(PersonaModel modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(PersonaModel modelo)
        {
            cnn.Delete(modelo);
        }
        public PersonaModel Consultar(int id)
        {
          return  cnn.Table<PersonaModel>().FirstOrDefault(p => p.IdPersona == id);
        }

        public List<PersonaModel> Consultar() {
            return cnn.Table<PersonaModel>().ToList();
        }

    }
}
