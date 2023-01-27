public class SecuritiesTrade
{
    public int Quantity;
    public decimal Price;

    public void Deconstruct(out int q, out decimal p) => (q, p) = (Quantity, Price);
}