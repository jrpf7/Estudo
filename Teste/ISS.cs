public class ISS : Imposto
{
    public double Calcula(Orcamento orcamento) => orcamento.Valor * 0.06;
}