using Pokemon;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Pokemones objetoP = new Pokemones();

/*Pokemon pikachu = new Pokemon();
        pikachu.Nombre = "Pikachu";
        pikachu.Tipo = "Eléctrico";
        pikachu.Habilidades[0] = 10;
        pikachu.Habilidades[1] = 20;
        pikachu.Habilidades[2] = 30;
        pikachu.Habilidades[3] = 40;
        pikachu.Defensa = 20.5m;
        pikachu.PropiedadPersonalizada1 = "Algo";
        pikachu.PropiedadPersonalizada2 = 123;*/

app.MapPost("/api/v1/pokemon/crearunpokemon", (PokemonDTO pokemon) =>
{
    objetoP.CrearPokemon(pokemon);
    return Results.Ok("Pokemon agregado exitosamente");

});

app.MapPost("/api/v1/pokemon/crearmuchospokemon", (PokemonDTO[] pokemones) =>
 {
     foreach (var poke in pokemones)
     {
         objetoP.CrearMuchosPokemones(pokemones);


     }

 });

app.MapPut("/api/v1/pokemon/actualizarpokemon/{Id}", (PokemonDTO pokemon, int Id) =>
{
    objetoP.EditarPokemon(Id, pokemon);
    return Results.Ok("Se a actualizado el pokemon");
});

app.MapDelete("/api/v1/pokemon/eliminarpokemon/{Id}", (int Id) =>
{
    objetoP.EliminarPokemon(Id);
    return Results.Ok("Se a eliminado el pokemon");
});


app.MapGet("/api/v1/pokemon/mostrarunpokemon/{id}", (int Id) =>
{
    return Results.Ok(objetoP.MostrarPokemon(Id));
});

app.MapGet("/api/v1/pokemon/mostrarpokemonportipo/{Tipo}", (string Tipo) =>
{
    return Results.Ok(objetoP.MostrarPokemonPorTipo(Tipo));
});

app.Run();


