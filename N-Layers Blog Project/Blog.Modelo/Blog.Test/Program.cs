// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

var apiUrl = "https://localhost:5001/api/entradas/";
var data = Blog.API.Consumer.Crud<Blog.Modelo.Entrada>.GetAll(apiUrl);

foreach (var ent in data)
{
	Console.WriteLine($"{ent.ContenidoEntrada}-{ent.Id}");
}

Console.WriteLine("----------------");
var ent2 = Blog.API.Consumer.Crud<Blog.Modelo.Entrada>.GetOne(apiUrl + "2");
Console.WriteLine($"{ent2.ContenidoEntrada}-{ent2.Id}");

Console.ReadKey();



/*
var apiUrl = "https://localhost:5001/api/entradas/";  // debe ser la direccion de producción
var webClient = new System.Net.WebClient();
webClient.Headers.Add("Content-Type", "application/json");
var json = webClient.DownloadString(apiUrl);

var entradas = Newtonsoft.Json.JsonConvert.DeserializeObject<Blog.Modelo.Entrada[]>(json);

foreach (var entrada in entradas)
{
	Console.WriteLine($"{entrada.ContenidoEntrada}-{entrada.Id}");
}

Console.ReadKey();


*/


/*var _context = new Blog.DAL.Context();


var nomina = new Blog.BL.Nomina(_context);

var mayores20 = nomina.ListaUsuarios(22);

foreach (var emp in mayores20)
{
	Console.WriteLine($"{emp.NombreUsuario} - {emp.Edad} - {emp.NombreEntrada} - {emp.ContenidoEntrada}");
}

Console.WriteLine(".................");
Console.ReadKey();
*/



/*
_context.Add(new Blog.Modelo.Usuario
{
	Id = 0,
	NombreUsuario = "David Enriquez",
	EdadUsuario = 22,
	SexoUsuario = "Hombre",

});

_context.Add(new Blog.Modelo.Usuario
{
	Id = 0,
	NombreUsuario = "Henry Ramirez",
	EdadUsuario = 20,
	SexoUsuario = "Hombre",

});

_context.Add(new Blog.Modelo.Usuario
{
	Id = 0,
	NombreUsuario = "Shesha Chamorro",
	EdadUsuario = 23,
	SexoUsuario = "Mujer",

});

_context.Add(new Blog.Modelo.Usuario
{
	Id = 0,
	NombreUsuario = "Diego Trejo",
	EdadUsuario = 42,
	SexoUsuario = "Hombre",

});

_context.Add(new Blog.Modelo.Usuario
{
	Id = 0,
	NombreUsuario = "Nathy Aguilar",
	EdadUsuario = 19,
	SexoUsuario = "Mujer",

});

_context.Add(new Blog.Modelo.Usuario
{
	Id = 0,
	NombreUsuario = "Pepito Alimaña",
	EdadUsuario = 13,
	SexoUsuario = "Hombre",

});
*/

/*
_context.Add(new Blog.Modelo.Tag
{
	Id = 0,
	TipoTag = "Juegos",
	NombreTag = "Zelda"

});

_context.Add(new Blog.Modelo.Tag
{
	Id = 0,
	TipoTag = "Musica",
	NombreTag = "Rock"

});

_context.Add(new Blog.Modelo.Tag
{
	Id = 0,
	TipoTag = "BellasArtes",
	NombreTag = "Pintura"

});

_context.Add(new Blog.Modelo.Tag
{
	Id = 0,
	TipoTag = "Educacion",
	NombreTag = "Matematica"

});

*/

/*
_context.Add(new Blog.Modelo.Entrada
{
	Id = 0,
	NombreEntrada = "Los mejores juegos del 2022",
	ContenidoEntrada = "Lorem ipsum",
	UsuarioId = 1,
});

_context.Add(new Blog.Modelo.Entrada
{
	Id = 0,
	NombreEntrada = "Los mejores juegos del 2021",
	ContenidoEntrada = "Lorem ipsum",
	UsuarioId = 1,
});

_context.Add(new Blog.Modelo.Entrada
{
	Id = 0,
	NombreEntrada = "Canciones de los 2000's",
	ContenidoEntrada = "Lorem ipsum",
	UsuarioId = 3,
});

_context.Add(new Blog.Modelo.Entrada
{
	Id = 0,
	NombreEntrada = "Mejores lenguajes de programacion",
	ContenidoEntrada = "Lorem ipsum",
	UsuarioId = 2,
});

_context.Add(new Blog.Modelo.Entrada
{
	Id = 0,
	NombreEntrada = "Mejores compiladores e idles",
	ContenidoEntrada = "Lorem ipsum",
	UsuarioId = 4,
});

_context.Add(new Blog.Modelo.Entrada
{
	Id = 0,
	NombreEntrada = "Pinturas del Barroco",
	ContenidoEntrada = "Lorem ipsum",
	UsuarioId = 5,
});

*/

/*
_context.Add(new Blog.Modelo.DetalleTag
{
	Id = 0,
	EntradaId = 1,
	TagId = 1,

});

_context.Add(new Blog.Modelo.DetalleTag
{
	Id = 0,
	EntradaId = 2,
	TagId = 1,

});
_context.Add(new Blog.Modelo.DetalleTag
{
	Id = 0,
	EntradaId = 3,
	TagId = 2,

});

_context.Add(new Blog.Modelo.DetalleTag
{
	Id = 0,
	EntradaId = 4,
	TagId = 4,

});

_context.Add(new Blog.Modelo.DetalleTag
{
	Id = 0,
	EntradaId = 5,
	TagId = 4,

});

_context.Add(new Blog.Modelo.DetalleTag
{
	Id = 0,
	EntradaId = 6,
	TagId = 3,

});
_context.SaveChanges();
Console.WriteLine("Se guardaron los cambios");
Console.ReadKey();
*/