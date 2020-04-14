using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using avance;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(avance.Droid.Configuration))]

namespace avance.Droid
{
    public class Configuration : IConfiguration
    {
        private string Directorio;
        private ISQLitePlatform Plataforma;

        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio)) {
                    Directorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return Directorio;
            }
        }

        ISQLitePlatform IConfiguration.plataforma
        {
            get
            {
                if (Plataforma==null) {
                    Plataforma = new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
                   
                }
                return Plataforma;
            }
        }
    }
}