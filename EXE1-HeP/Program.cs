namespace EXE1_HeP;
class Program
{
    static void Main(string[] args)
    {
        Gato gato = new Gato();
        Humano humano = new Humano();
        Cao cao = new Cao();

         Console.WriteLine("O gato faz " + gato.som() );
         Console.WriteLine("O Humano fala " + humano.som() );
         Console.WriteLine("O cachorro faz " + cao.som() );
    }
}
