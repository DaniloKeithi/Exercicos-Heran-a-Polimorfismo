namespace EX2;
class ContratoPJ: Contrato
{
     public string? CNPJ {get;set;}
 public string? IdadeE {get;set;}

    public override string MostraDados(){

        string infos = "/" + " CNPJ " + CNPJ + "/" + " Idade Empresa " + IdadeE + "/";

        return base.MostraDados() + infos;
    }
    
    
}