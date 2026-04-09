// aqui é a classe que é o genero ou a categoria do filme
public class Categoria
{
    // aqui vai guardar na variavel a categoria e não pode ser mudado depois
    public string Nome { get; }

    public Categoria(string nome)
    {
        Nome = nome;
    }
}
