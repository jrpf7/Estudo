public class ICMS : Imposto
{
    public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.1;
}