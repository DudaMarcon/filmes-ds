class Program
{// aqui é onde o programa começa a rodar

    static void Main(string[] args)
    {
// Aqui estou criando as categorias, e elas n podem ser mudadas
        Categoria suspense = new Categoria(" Suspense");
        Categoria comedia = new Categoria(" Comédia");

//Aqui eu estou colocando as caracteristicas do filme 
        Filme filme1 = new Filme("Ilha do Medo", 138, suspense);
        Filme filme2 = new Filme("As Branquelas", 114, comedia);
        Filme filme3 = new Filme("Gente Grande", 102, comedia);

// Aqui está chamando o "public void Exibir" que eu fiz em filmes.cs
//Então aqui vai mostrar ao usuario da forma que eu defini lá
        filme1.Exibir();
        filme2.Exibir();
        filme3.Exibir();
    }
}