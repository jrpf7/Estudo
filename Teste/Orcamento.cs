public class Orcamento
{
    public double Valor { get; private set; }
    public IList<Item> Itens { get; private set; }

    public Orcamento(double valor)
    {
        this.Valor = valor;
        this.Itens = new();
    }

    public void AdicionaItem(Item item)
    {
        this.Itens.Add(item);
    }

}