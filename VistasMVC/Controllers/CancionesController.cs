using LibreriaVistas;
using Microsoft.AspNetCore.Mvc;

namespace VistasMVC;

public class CancionesController : Controller
{
    public IActionResult Index()
    {
        Tarjeta cancion1 = new Tarjeta();
        cancion1.Autor = "Ichika Aozora";
        cancion1.Descripcion = "Red Heart Rage  es una canción de personaje para el personaje Riddle Rosehearts del juego Twisted Wonderland, diseñado por Yana Toboso, que forma parte de la empresa de entretenimiento Disney";
        cancion1.Fecha = new DateTime(2025, 9, 18);
        cancion1.Imagen = "/CardRiddle.png";
        cancion1.Titulo = "Red Heart Rage";

         Tarjeta cancion2 = new Tarjeta();
        cancion2.Autor = "Melanie Martinez";
        cancion2.Descripcion = "Mad Hatter es una canción de Melanie Martinez incluida como la decimotercera pista en su álbum debut, CryBaby. Es la última canción en la versión estándar del álbum.";
        cancion2.Fecha = new DateTime(2019, 8, 20);
        cancion2.Imagen = "https://pbs.twimg.com/profile_images/1955157234373234688/P53LEKYt_400x400.jpg";
        cancion2.Titulo = "Mad Hatter";

         Tarjeta cancion3 = new Tarjeta();
        cancion3.Autor = "Taylor Swift";
        cancion3.Descripcion = "« King of My Heart » es una canción de la cantautora estadounidense Taylor Swift";
        cancion3.Fecha = new DateTime(2017, 11, 10);
        cancion3.Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQMgWfJjCpjmAoTaAcuH7gAWEaBh38GFvIV6w&s";
        cancion3.Titulo = "King of My Heart";

         Tarjeta cancion4 = new Tarjeta();
        cancion4.Autor = "Tomorrow x Together";
        cancion4.Descripcion = "Una canción del album The Dream Chapter: Magic";
        cancion4.Fecha = new DateTime(2019, 10, 9);
        cancion4.Imagen = "https://i.scdn.co/image/ab67616d0000b2736207621becafe079ec6c9185";
        cancion4.Titulo = "Run Away";

        Tarjeta cancion5 = new Tarjeta();
        cancion5.Autor = "Meychan";
        cancion5.Descripcion = "Es una canción que trata sobre el amor obsesivo y acosador que siente una chica hacia alguien que ama.";
        cancion5.Fecha = new DateTime(2025, 9, 11);
        cancion5.Imagen = "https://i.scdn.co/image/ab67616d0000b27318ff812628d82753af022343";
        cancion5.Titulo = "See you next attack";

         Tarjeta cancion6 = new Tarjeta();
        cancion6.Autor = "yoshimoto ojisan";
        cancion6.Descripcion = "Trata sobre una chica recibiendo mensajes de un viejo desconocido xd";
        cancion6.Fecha = new DateTime(2025, 5, 31);
        cancion6.Imagen = "https://is1-ssl.mzstatic.com/image/thumb/Music221/v4/70/7b/65/707b65f6-df7f-7be4-69e3-cd799d7bcf52/4550709469913_cover.png/600x600bf-60.jpg";
        cancion6.Titulo = "Still waiting for your reply?-Ojisan style text";

        Tarjeta cancion7 = new Tarjeta();
        cancion7.Autor = "Three";
        cancion7.Descripcion = "Me encanta esta canción, es todo.";
        cancion7.Fecha = new DateTime(2023, 10, 6);
        cancion7.Imagen = "https://images.genius.com/380c3817d336fdd4faa2b229eb06d15d.1000x1000x1.jpg";
        cancion7.Titulo = "Bakaninatte";

         Tarjeta cancion8 = new Tarjeta();
        cancion8.Autor = "PinocchioP";
        cancion8.Descripcion = "No creas...";
        cancion8.Fecha = new DateTime(2025, 6, 27);
        cancion8.Imagen = "https://i.scdn.co/image/ab67616d0000b2733d1f05effa47909ed141e0c0";
        cancion8.Titulo = "Don't believe in T";

        
        List<Tarjeta> lista = new List<Tarjeta>();
        lista.Add(cancion1);
        lista.Add(cancion2);
        lista.Add(cancion3);
        lista.Add(cancion4);
        lista.Add(cancion5);
        lista.Add(cancion6);
        lista.Add(cancion7);
        lista.Add(cancion8);

        return View(lista);
        
    }
}