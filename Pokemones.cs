namespace Pokemon;

// Clase que gestiona los datos de Pokemon en memoria
class Pokemones : IPokemon
{
    private List<PokemonDTO> BD;

    public Pokemones()
    {
        this.BD = new List<PokemonDTO>();
    }

    public void CrearPokemon(PokemonDTO pokemon)
    {
        this.BD.Add(pokemon);
    }

    public void CrearMuchosPokemones(PokemonDTO[] pokemones)
    {
        foreach (PokemonDTO objeto1 in pokemones)
        {
            this.BD.Add(objeto1);
        }
    }

    public void EditarPokemon(int Id, PokemonDTO pokemon)
    {
        PokemonDTO actualizarpokemones = this.BD.Single(pokemon => pokemon.Id == Id);
        actualizarpokemones.Nombre = pokemon.Nombre;
        actualizarpokemones.Habilidades = pokemon.Habilidades;
        actualizarpokemones.Tipo = pokemon.Tipo;
        this.BD[Id - 1] = actualizarpokemones;
    }


    public void EliminarPokemon(int Id)
    {
        this.BD.RemoveAll(pokemon => pokemon.Id == Id);
    }

    public PokemonDTO MostrarPokemon(int Id)
    {
        PokemonDTO obtener = this.BD.Single(Pokemones => Pokemones.Id == Id);
        return obtener;
    }

    public List<PokemonDTO> MostrarPokemonPorTipo(string Tipo)
    {
        var Tipopokemon = this.BD.Where(pokemon => pokemon.Tipo == Tipo);
        List<PokemonDTO> list = Tipopokemon.ToList();
        return list;
    }


}