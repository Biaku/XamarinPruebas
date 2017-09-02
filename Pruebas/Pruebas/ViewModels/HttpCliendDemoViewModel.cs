using Pruebas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Pruebas.ViewModels
{
    public class HttpCliendDemoViewModel
    {
        public ObservableCollection<Publicacion> Publicaciones { get; set; }

        public HttpCliendDemoViewModel()
        {
            Publicaciones = new ObservableCollection<Publicacion>();
            ObtenerPublicaciones();
        }

        public async Task<List<Publicacion>> GetPublicacionesAsync()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync("http://pooplife.mx/api/publicacion/");
            var todoItems = JsonConvert.DeserializeObject<List<Publicacion>>(response);
            return todoItems;
        }
        public async void ObtenerPublicaciones()
        {
            var publicaciones = await GetPublicacionesAsync();
            mostrarPublicaciones(publicaciones);
        }

        private void mostrarPublicaciones(List<Publicacion>publicaciones)
        {
            Publicaciones.Clear();
            foreach (var publicacion in publicaciones)
            {
                Publicaciones.Add(new Publicacion
                {
                    mensaje = publicacion.mensaje
                });
            }
        }
    }
}
