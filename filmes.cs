public class Filme
{
// Aqui eu estou definindo as informacoes do filme que são o titulo a duracao e genero
// e como tem get e set da pra mudar depois se precisar
    public string Tit { get; set; }
    public int Dura{ get; set; }
    public Categoria Gen { get; set; }

// Aqui eu pego o titulo, duracao e genero que foram passados e armazeno nas variaveis que eu criei
    public Filme(string tit, int dura, Categoria gen)
    {
        Tit = tit;
        Dura = dura;
        Gen = gen;
    }

// Aqui está montando o jeito que vai aparecer para o usuario no terminal com o nome do filme a duração e o genero
//por isso o Exibir
    public void Exibir()
    {
        Console.WriteLine("Filme: " + Tit +   " | Duracao: " + Dura + " minutos" +  " | Genero:" + Gen.Nome);
    }
}