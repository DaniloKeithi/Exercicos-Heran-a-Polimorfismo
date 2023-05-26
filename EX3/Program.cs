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
        cf.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira seu CPF");
        cf.CPF = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(cf.MostraDados());

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Contrato Pessoa Fisica");
        Console.WriteLine("Valores");
        Console.WriteLine("");
        Console.WriteLine("Digite o valor total que deja parcelar: ");
        cf.Valor = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de vazes que deseja parcelar");
        cf.Parcelas = int.Parse(Console.ReadLine());
                
        Console.Clear();
        Console.WriteLine(cf.MostraDados());
        Console.WriteLine("O valor das parcelas é de: R$" + cf.CalcularPrestação(cf.Valor, cf.Parcelas) + ",00 por " + cf.Parcelas + " meses");

       
        

 
        

        Console.WriteLine("Contrato Juridica:");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Insira seu nome:" );
        cj.Nome = Console.ReadLine();
        Console.WriteLine("Insira seu Email");
        cj.Email = Console.ReadLine();
        Console.WriteLine("Insira seu Telefone");
        cj.Telefone = Console.ReadLine();
        Console.WriteLine("Insira a idade da sua empresa");
        cj.IdadeE = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira seu CNPJ");
        cj.CNPJ = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");



        Console.WriteLine(cj.MostraDados());

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("Contrato Pessoa Jurídica");
        Console.WriteLine("Valores");
        Console.WriteLine("");
        Console.WriteLine("Digite o valor total que deja parcelar: ");
        cj.Valor = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de vazes que deseja parcelar");
        cj.Parcelas = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine(cj.MostraDados());
        Console.WriteLine("O valor das parcelas é de: R$" + cj.CalcularPrestação(cj.Valor, cj.Parcelas) + ",00 por " + cj.Parcelas + " meses" );
     
        

      

        




        


    }
}
