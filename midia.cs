public class Midia
{
    public string Tit;
    public int Dura;

    public Midia(string tit, int dura)
    {
        if (tit == "")
        {
            Console.WriteLine("Precisa ter um título");
        }

        if (dura <= 0)
        {
            Console.WriteLine("A duração é inválida ");
        }

        Tit = tit;
        Dura = dura;
    }

    public void Exibir()
    {
        Console.WriteLine("Título: " + Tit + " | Duracao: " + Dura);
    }
}