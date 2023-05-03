namespace Pokemon;
// Interfaz para definir los métodos de la clase que gestiona los datos de Pokemon
interface IPokemon
{
    public void CrearPokemon(PokemonDTO pokemon);

    public void CrearMuchosPokemones(PokemonDTO[] pokemones);

    public void EditarPokemon(int Id, PokemonDTO pokemon);

    public void EliminarPokemon(int Id);

    public PokemonDTO MostrarPokemon(int Id);

    public List<PokemonDTO> MostrarPokemonPorTipo(string Tipo);
}