namespace EX2;
class Contrato
{
    public string? Nome {get;set;}
    public string? Email {get;set;}
    public string? Telefone {get;set;}
    public int Valor{get;set;}
    public int Parcelas{get;set;}

    public virtual string MostraDados(){
    
    string infos = "Nome: " + this.Nome + "/" + " Email: " + this.Email + "/"  + " Telefone " + this.Telefone;

    return infos;
    }

    public virtual double CalcularPrestação(int Valor, int Parcelas)
    {
        return Valor/Parcelas;
    }
}
