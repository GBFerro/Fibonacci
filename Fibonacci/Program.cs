internal class Program
{
    private static void Main(string[] args)
    {
        int ant, atual, posicao;

        Console.WriteLine("Digite a posição da sequencia que quer ver: ");
        posicao = int.Parse(Console.ReadLine());

        atual = 1;
        ant = 1;

        for (int i = posicao; i > 0; i--)
        {

            if ((i == posicao) || (i == posicao - 1))
            {
                Console.Write(atual + " | ");
            }
            else
            {
                Console.Write(atual + ant + " | ");
                atual += ant;
                ant = atual - ant;

            }
        }
    }
}