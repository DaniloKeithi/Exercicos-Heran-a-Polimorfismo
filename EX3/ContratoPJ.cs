namespace EX2;
class ContratoPJ: Contrato
{
     public string? CNPJ {get;set;}
 public int IdadeE {get;set;}

    public override string MostraDados(){

        string infos = "/" + " CNPJ " + CNPJ + "/" + " Idade Empresa " + IdadeE + "/";

        return base.MostraDados() + infos;
    }

     public override double CalcularPrestação(int Valor, int Parcelas){
        return  base.CalcularPrestação(Valor, Parcelas) + 3;
    }
    
    
}