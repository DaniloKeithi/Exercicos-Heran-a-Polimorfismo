namespace EX2;
class ContratoPF: Contrato
{
 public string? CPF {get;set;}
 public string? Idade {get;set;}

    public override string MostraDados(){
         string infos = "/" + " CPF " + CPF + "/" + " Idade " + Idade + "/";

        return base.MostraDados() + infos;
    }

}