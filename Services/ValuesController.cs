using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ELocal.Services
{
    public interface IEventService
    {
        IEnumerable<Event> GetUpcomingEvents();
        Event GetEventById(int id);
    }

    public class EventService : IEventService
    {
        private readonly List<Event> _events;

        public EventService()
        {
            _events = new List<Event>
        {
            new Event
{
    Id = 1,
    Name = "Festival Cultural en Santo Domingo",
    Description = "Únete a nosotros para un día lleno de cultura, música, y diversión en el Parque Colón. Disfruta de presentaciones en vivo, exhibiciones de arte, y una gran variedad de comidas locales. Ideal para familias y amigos que deseen experimentar la riqueza cultural de la República Dominicana.",
    Date = new DateTime(2024, 10, 15),
    Location = "Parque Colón, Santo Domingo",
    ImageUrl = "~/wwwroot/ex.jpg"
},
new Event
{
    Id = 2,
    Name = "Concierto en la Playa de Punta Cana",
    Description = "Disfruta de un paraíso tropical mientras asistes a exclusivos festivales de música en la hermosa Playa Bávaro. Con artistas internacionales y locales, este evento promete ser una experiencia inolvidable junto al mar.",
    Date = new DateTime(2024, 11, 10),
    Location = "Playa Bávaro, Punta Cana",
    ImageUrl = "https://example.com/image2.jpg"
},
new Event
{
    Id = 3,
    Name = "Feria del Libro en Santiago",
    Description = "Explora la rica literatura dominicana e internacional en la Feria del Libro de Santiago. Habrá charlas, firmas de libros y actividades para todas las edades, haciendo de este evento un lugar perfecto para los amantes de la lectura.",
    Date = new DateTime(2024, 10, 20),
    Location = "Plaza Valerio, Santiago",
    ImageUrl = "https://example.com/image3.jpg"
},
new Event
{
    Id = 4,
    Name = "Carnaval de La Vega",
    Description = "Vive la tradición dominicana en el Carnaval de La Vega, uno de los más antiguos y vibrantes del país. Disfruta de desfiles, música, y las coloridas máscaras de los 'diablos cojuelos' que hacen de este evento una experiencia única.",
    Date = new DateTime(2024, 02, 18),
    Location = "Calle Principal, La Vega",
    ImageUrl = "https://example.com/image4.jpg"
},
new Event
{
    Id = 5,
    Name = "Festival de Jazz en Casa de Campo",
    Description = "Sumérgete en la magia del jazz con artistas de renombre mundial en un entorno lujoso. El Festival de Jazz en Casa de Campo ofrece una combinación de música, elegancia y el ambiente exclusivo de este famoso resort.",
    Date = new DateTime(2024, 11, 05),
    Location = "Anfiteatro Altos de Chavón, Casa de Campo",
    ImageUrl = "https://example.com/image5.jpg"
},
new Event
{
    Id = 6,
    Name = "Festival de Cine Global en Santo Domingo",
    Description = "El Festival de Cine Global trae lo mejor del cine internacional y local a Santo Domingo. Con proyecciones, paneles y charlas con cineastas reconocidos, este evento es una cita imperdible para los amantes del séptimo arte.",
    Date = new DateTime(2024, 12, 01),
    Location = "Teatro Nacional, Santo Domingo",
    ImageUrl = "https://example.com/image6.jpg"
},
new Event
{
    Id = 7,
    Name = "Expo Cibao 2024",
    Description = "La mayor feria empresarial del Cibao regresa con más de 300 expositores de diversos sectores. Conéctate con líderes de la industria, descubre innovaciones y disfruta de actividades culturales durante toda la semana.",
    Date = new DateTime(2024, 09, 20),
    Location = "Centro de Convenciones, Santiago",
    ImageUrl = "https://example.com/image7.jpg"
},
new Event
{
    Id = 8,
    Name = "Maratón de Santo Domingo",
    Description = "Participa en el evento deportivo más grande de la capital. El Maratón de Santo Domingo atrae a corredores de todo el mundo que vienen a desafiarse en un recorrido por los lugares más emblemáticos de la ciudad.",
    Date = new DateTime(2024, 12, 15),
    Location = "Avenida George Washington, Santo Domingo",
    ImageUrl = "https://example.com/image8.jpg"
},
new Event
{
    Id = 9,
    Name = "Semana Santa en Puerto Plata",
    Description = "Disfruta de una experiencia única durante la Semana Santa en Puerto Plata. Con procesiones, conciertos de música sacra y un ambiente de reflexión, este evento es perfecto para aquellos que buscan una experiencia espiritual en la costa norte.",
    Date = new DateTime(2024, 04, 14),
    Location = "Malecón, Puerto Plata",
    ImageUrl = "https://example.com/image9.jpg"
},
new Event
{
    Id = 10,
    Name = "Festival Gastronómico en Samaná",
    Description = "Deléitate con los sabores de la gastronomía dominicana e internacional en el Festival Gastronómico de Samaná. Los mejores chefs del país se reúnen para ofrecer una experiencia culinaria inolvidable en un entorno paradisíaco.",
    Date = new DateTime(2024, 07, 25),
    Location = "Playa Las Terrenas, Samaná",
    ImageUrl = "https://example.com/image10.jpg"
},
new Event
{
    Id = 11,
    Name = "Festival de la Bachata en Cabarete",
    Description = "Baila al ritmo de la bachata en las playas de Cabarete. Este festival reúne a los mejores bailarines y músicos del género en un evento que celebra la música y cultura dominicana.",
    Date = new DateTime(2024, 06, 10),
    Location = "Playa Cabarete, Puerto Plata",
    ImageUrl = "https://example.com/image11.jpg"
},
new Event
{
    Id = 12,
    Name = "Feria Artesanal en Jarabacoa",
    Description = "Descubre la artesanía dominicana en la Feria Artesanal de Jarabacoa. Con una amplia variedad de productos hechos a mano, desde cerámicas hasta textiles, este evento es ideal para encontrar piezas únicas y apoyar a los artesanos locales.",
    Date = new DateTime(2024, 05, 15),
    Location = "Parque Central, Jarabacoa",
    ImageUrl = "https://example.com/image12.jpg"
},
new Event
{
    Id = 13,
    Name = "Festival del Ron en San Pedro de Macorís",
    Description = "Celebra el orgullo del ron dominicano en el Festival del Ron en San Pedro de Macorís. Con degustaciones, talleres y conciertos en vivo, este evento es un homenaje a una de las exportaciones más queridas de la isla.",
    Date = new DateTime(2024, 08, 01),
    Location = "Malecón, San Pedro de Macorís",
    ImageUrl = "https://example.com/image13.jpg"
},
new Event
{
    Id = 14,
    Name = "Festival de Música Clásica en Santo Domingo",
    Description = "Disfruta de una velada con la mejor música clásica interpretada por orquestas y solistas internacionales. El Festival de Música Clásica en Santo Domingo es un evento que combina la excelencia musical con la majestuosidad del Teatro Nacional.",
    Date = new DateTime(2024, 03, 20),
    Location = "Teatro Nacional, Santo Domingo",
    ImageUrl = "https://example.com/image14.jpg"
},
new Event
{
    Id = 15,
    Name = "Festival de Arte Urbano en Santo Domingo",
    Description = "Explora la vibrante escena de arte urbano en Santo Domingo. Con grafitis, instalaciones y performances en vivo, este festival transforma las calles de la ciudad en una galería de arte al aire libre.",
    Date = new DateTime(2024, 05, 01),
    Location = "Zona Colonial, Santo Domingo",
    ImageUrl = "https://example.com/image15.jpg"
},
new Event
{
    Id = 16,
    Name = "Festival Internacional de Danza en Santiago",
    Description = "Santiago se convierte en el escenario de las mejores compañías de danza de todo el mundo. El Festival Internacional de Danza ofrece presentaciones de ballet, danza contemporánea y folclore, en un evento que celebra la diversidad y la belleza del movimiento.",
    Date = new DateTime(2024, 07, 05),
    Location = "Gran Teatro del Cibao, Santiago",
    ImageUrl = "https://example.com/image16.jpg"
},
new Event
{
    Id = 17,
    Name = "Expo Turismo en Puerto Plata",
    Description = "Conéctate con la industria turística en la Expo Turismo de Puerto Plata. Este evento reúne a operadores turísticos, hoteles, y otros actores clave del sector para mostrar lo mejor de la oferta turística de la región norte.",
    Date = new DateTime(2024, 09, 10),
    Location = "Centro de Convenciones, Puerto Plata",
    ImageUrl = "https://example.com/image17.jpg"
},
new Event
{
    Id = 18,
    Name = "Festival de las Flores en Jarabacoa",
    Description = "Jarabacoa se viste de color con el Festival de las Flores, un evento que celebra la belleza natural de esta región montañosa. Con exhibiciones florales, concursos y actividades familiares, este festival es una celebración de la naturaleza y la cultura local.",
    Date = new DateTime(2024, 06, 20),
    Location = "Parque Central, Jarabacoa",
    ImageUrl = "https://example.com/image18.jpg"
},
new Event
{
    Id = 19,
    Name = "Festival Internacional del Merengue en Santo Domingo",
    Description = "El ritmo contagioso del merengue toma las calles de Santo Domingo en este festival internacional. Con las mejores bandas y orquestas de merengue, este evento es una fiesta sin fin que celebra la música y la danza dominicana.",
    Date = new DateTime(2024, 11, 25),
    Location = "Malecón, Santo Domingo",
    ImageUrl = "https://example.com/image19.jpg"
},
new Event
{
    Id = 20,
    Name = "Festival de Cine Dominicano en Puerto Plata",
    Description = "Descubre lo mejor del cine dominicano en este festival que reúne a cineastas, actores y amantes del cine en Puerto Plata. Con proyecciones, paneles y premios, este evento es una plataforma clave para la industria cinematográfica del país.",
    Date = new DateTime(2024, 12, 05),
    Location = "Cine Malecón, Puerto Plata",
    ImageUrl = "https://example.com/image20.jpg"
},
new Event
{
    Id = 21,
    Name = "Festival de la Cerveza en Bávaro",
    Description = "Únete a los amantes de la cerveza en el Festival de la Cerveza en Bávaro. Con una selección de cervezas artesanales locales e internacionales, este evento es una celebración del sabor y la creatividad en un entorno relajado junto al mar.",
    Date = new DateTime(2024, 08, 20),
    Location = "Playa Bávaro, Punta Cana",
    ImageUrl = "https://example.com/image21.jpg"
},
new Event
{
    Id = 22,
    Name = "Festival del Café en Jarabacoa",
    Description = "Para los amantes del café, el Festival del Café en Jarabacoa es una cita obligada. Con degustaciones, talleres y exposiciones de los mejores caficultores del país, este evento celebra la pasión por el café en un entorno natural impresionante.",
    Date = new DateTime(2024, 10, 05),
    Location = "Finca de Café, Jarabacoa",
    ImageUrl = "https://example.com/image22.jpg"
},
new Event
{
    Id = 23,
    Name = "Festival de la Palmera en Samaná",
    Description = "Descubre la biodiversidad única de Samaná en el Festival de la Palmera. Con caminatas ecológicas, talleres sobre conservación y actividades familiares, este evento es una celebración de la naturaleza en una de las regiones más hermosas del país.",
    Date = new DateTime(2024, 09, 15),
    Location = "Parque Nacional Los Haitises, Samaná",
    ImageUrl = "https://example.com/image23.jpg"
},
new Event
{
    Id = 24,
    Name = "Festival de las Aves en Puerto Plata",
    Description = "Explora la riqueza avifaunística de la República Dominicana en el Festival de las Aves en Puerto Plata. Con avistamientos guiados, charlas y actividades educativas, este evento es perfecto para los amantes de la naturaleza y la observación de aves.",
    Date = new DateTime(2024, 10, 25),
    Location = "Reserva Científica Isabel de Torres, Puerto Plata",
    ImageUrl = "https://example.com/image24.jpg"
},
new Event
{
    Id = 25,
    Name = "Festival del Cacao en San Francisco de Macorís",
    Description = "Celebra uno de los productos más emblemáticos de la República Dominicana en el Festival del Cacao. Con talleres, degustaciones y exposiciones, este evento destaca la importancia del cacao en la cultura y la economía del país.",
    Date = new DateTime(2024, 12, 10),
    Location = "Parque Duarte, San Francisco de Macorís",
    ImageUrl = "https://example.com/image25.jpg"
},
new Event
{
    Id = 26,
    Name = "Festival de la Miel en Constanza",
    Description = "Descubre el dulce mundo de la apicultura en el Festival de la Miel en Constanza. Con degustaciones, talleres sobre producción de miel y una feria de productos derivados, este evento es una delicia para los amantes de la miel.",
    Date = new DateTime(2024, 11, 15),
    Location = "Centro Cultural, Constanza",
    ImageUrl = "https://example.com/image26.jpg"
},
new Event
{
    Id = 27,
    Name = "Festival de la Lluvia de Estrellas en Punta Cana",
    Description = "Experimenta la magia del cielo nocturno en el Festival de la Lluvia de Estrellas en Punta Cana. Con observaciones guiadas, charlas de astrónomos y actividades educativas, este evento es una oportunidad única para conectar con el cosmos.",
    Date = new DateTime(2024, 12, 20),
    Location = "Playa Blanca, Punta Cana",
    ImageUrl = "https://example.com/image27.jpg"
},
new Event
{
    Id = 28,
    Name = "Festival del Plátano en Barahona",
    Description = "El plátano, uno de los productos básicos de la dieta dominicana, tiene su propio festival en Barahona. Con concursos de cocina, degustaciones y actividades culturales, este evento celebra la versatilidad y sabor de este alimento.",
    Date = new DateTime(2024, 11, 25),
    Location = "Parque Central, Barahona",
    ImageUrl = "https://example.com/image28.jpg"
},
new Event
{
    Id = 29,
    Name = "Festival de la Lana en Jarabacoa",
    Description = "Celebra la tradición textil de la lana en el Festival de la Lana en Jarabacoa. Con talleres, exhibiciones y una feria de productos de lana, este evento es un homenaje a la artesanía y la cultura local.",
    Date = new DateTime(2024, 09, 10),
    Location = "Plaza de la Artesanía, Jarabacoa",
    ImageUrl = "https://example.com/image29.jpg"
},
new Event
{
    Id = 30,
    Name = "Festival del Pescado en Sánchez",
    Description = "Disfruta de los sabores del mar en el Festival del Pescado en Sánchez. Con concursos de pesca, degustaciones de platos de mariscos y actividades para toda la familia, este evento es una celebración de la vida marina y la gastronomía local.",
    Date = new DateTime(2024, 08, 10),
    Location = "Malecón, Sánchez",
    ImageUrl = "https://example.com/image30.jpg"
},
            // Agrega más eventos aquí
        };
        }

        public IEnumerable<Event> GetUpcomingEvents()
        {
            return _events;
        }

        public Event GetEventById(int id)
        {
            return _events.FirstOrDefault(e => e.Id == id);
        }
    }
}
