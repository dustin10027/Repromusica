using Repromusica.Modelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repromusica.Datos
{
    public class Dmusica
    {
        public async Task <List<Mmusica>> Listarmusica()
        {
            var lista = new List<Mmusica>()
            {
                new Mmusica
                {
                    Nombre="Less than zero",
                    Autor="The Weeknd",
                    Icono= "https://i.ibb.co/s1BPcRQ/the-weeknd-dawn-fm.jpg",
                    Url= "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/The%20Weeknd%20-%20Less%20Than%20Zero.mp3?alt=media&token=066c9b70-22cf-48ce-9f48-5e809bf54142"
                },
                 new Mmusica
                 {
                     Nombre = "Is there someone else",
                     Autor = "The Weeknd",
                     Icono = "https://i.ibb.co/s1BPcRQ/the-weeknd-dawn-fm.jpg"
                ,
                     Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/The%20Weeknd%20-%20Is%20There%20Someone%20Else.mp3?alt=media&token=d4f03476-1c6e-4d7c-9fa7-f76a6d48d9c8"
                 },
                  new Mmusica
                  {
                      Nombre = "Noches de soledad",
                      Autor = "Tiago pzk ft Asan y khea",
                      Icono = "https://i.ibb.co/JjCdVKr/maxresdefault.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Tiago%20PZK%20Ft.%20Asan%20Y%20Khea%20-%20Noches%20De%20Soledad.mp3?alt=media&token=a9586bfb-d9a6-44e9-ad06-580bc85eda2a"
                  },
                  new Mmusica
                  {
                      Nombre = "Ipad",
                      Autor = "The Chainsmokers",
                      Icono = "https://i.ibb.co/N7yz88M/artworks-l-Nw7-UIj68x-CH-0-t500x500.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/03%20-%20iPad.mp3?alt=media&token=58e55a3c-2a27-499c-af34-4a39089f5cb0"
                  },
                  new Mmusica
                  {
                      Nombre = "Fuera Del Planeta Remix",
                      Autor = "Eloy Ft. Jowell Y Randy, Zion",
                      Icono = "https://i.ibb.co/CmV4GYJ/hqdefault.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Eloy%20Ft.%20Jowell%20Y%20Randy%2C%20Zion%20-%20Fuera%20Del%20Planeta%20Remix.mp3?alt=media&token=c2e143a4-0cb3-4a5b-aa25-27b2acd7c6cb"
                  },
                   new Mmusica
                  {
                      Nombre = "Ven Conmigo",
                      Autor = "Daddy Yankee Ft. Prince Royce",
                      Icono = "https://i.ibb.co/JyrQBHM/hqdefault-1.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Daddy%20Yankee%20Ft.%20Prince%20Royce%20-%20Ven%20Conmigo.mp3?alt=media&token=5d539152-ef90-4cf8-b6c0-ae7bccb41489"
                  },
                    new Mmusica
                  {
                      Nombre = "Higher Power",
                      Autor = "Coldplay",
                      Icono = "https://i.ibb.co/0MNkpTv/ee0e269e-fdc9-4f5c-ba5b-86357281efc6.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Coldplay%20-%20Higher%20Power%20-%20Espa%C3%B1ol%20%2B%20Lyrics%20(VIDEO%20OFICIAL)%20HD.mp3?alt=media&token=13078e2c-507d-4c0f-a604-5275fdf21dcf"
                  },
                     new Mmusica
                  {
                      Nombre = "Feliz Cumpleaños Ferxxo",
                      Autor = "Feid",
                      Icono = "https://i.ibb.co/GRx07jk/59e0e6c0c65b1f21c55dc0a4b5cc2648-1000x1000x1.png"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Feid%20-%20Feliz%20Cumplea%C3%B1os%20Ferxxo(128).mp3?alt=media&token=09b84726-578f-4c0d-aad0-467b8a2eaa32"
                  },
                     new Mmusica
                  {
                      Nombre = "Vagabundo",
                      Autor = "Sebastián Yatra Ft. Manuel Turizo Y Beéle",
                      Icono = "https://i.ibb.co/SXRv3Xn/Vagabundo.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Sebasti%C3%A1n%20Yatra%20Ft.%20Manuel%20Turizo%20Y%20Be%C3%A9le%20-%20Vagabundo.mp3?alt=media&token=f87ae5fc-5420-4295-8602-975476fffa22"
                  },
                     new Mmusica
                  {
                      Nombre = "Un Finde",
                      Autor = "Big One Ft. FMK Y Ke personajes",
                      Icono = "https://i.ibb.co/yyZRTct/maxresdefault.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/Big%20One%20Ft.%20FMK%20Y%20Ke%20personajes%20-%20Un%20Finde%20(2).mp3?alt=media&token=50a7d316-b956-40e2-8254-aea5e4fa8470"
                  },
                     new Mmusica
                  {
                      Nombre = "Somebody Else",
                      Autor = "The 1975",
                      Icono = "https://i.ibb.co/PNtZdm8/artworks-r9pmv-EOOKQe-NDGLc-0s5ytg-t500x500.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/10%20-%20Somebody%20Else.mp3?alt=media&token=b4d16748-653c-4a43-bce2-5bf2d28ba7d6"
                  },
                     new Mmusica
                  {
                      Nombre = "On Melancholy Hill",
                      Autor = "Gorillaz",
                      Icono = "https://i.ibb.co/m41ptLD/ab67616d0000b273661d019f34569f79eae9e985.jpg"
                     ,
                      Url = "https://firebasestorage.googleapis.com/v0/b/musicaapp-f074a.appspot.com/o/10%20-%20On%20Melancholy%20Hill.mp3?alt=media&token=e3e2a991-f201-490a-ad0c-3a2f5ad90eec"
                  }

            };
            return lista;
        }
    }
}
