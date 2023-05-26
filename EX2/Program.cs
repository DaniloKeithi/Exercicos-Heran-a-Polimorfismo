namespace EX2;
class Program
{
    static void Main(string[] args)
    {
        Contrato c = new Contrato();
        ContratoPF cf = new ContratoPF();
        ContratoPJ cj = new ContratoPJ();

        Console.WriteLine("Contrato Pessoa Fisica:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Insira seu nome:" );
        cf.Nome = Console.ReadLine();
        Console.WriteLine("Insira seu Email");
        cf.Email = Console.ReadLine();
        Console.WriteLine("Insira seu Telefone");
        cf.Telefone = Console.ReadLine();
        Console.WriteLine("Insira sua Idade");
        cf.Idade = Console.ReadLine();
        Console.WriteLine("Insira seu CPF");
        cf.CPF = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(cf.MostraDados());

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
       
        

 
        

        Console.WriteLine("Contrato Juridica:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Insira seu nome:" );
        cj.Nome = Console.ReadLine();
        Console.WriteLine("Insira seu Email");
        cj.Email = Console.ReadLine();
         Console.WriteLine("Insira seu Telefone");
        cj.Telefone = Console.ReadLine();
          Console.WriteLine("Insira a idade da sua empresa");
        cj.IdadeE = Console.ReadLine();
          Console.WriteLine("Insira seu CNPJ");
        cj.CNPJ = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");



        Console.WriteLine(cj.MostraDados());
     
        

      

        




        


    }
}
