namespace Demo1.Model;

public class Phone
{
    public Phone()
    {
    }

    public int Id { get; set; }
    public string Model { get; set; }
    public double Size { get; set; }
    public int Price { get; set; }
    public string Color { get; set; }
    public int CompanyId { get; set; }
    public Company Company { get; set; }

    public Phone SetSize(double value)
    {
        Size = value;
        return this;
    }
    public Phone SetModel(string value)
    {
        Model = value;
        return this;
    }
    public Phone SetPrice(int value)
    {
        Price = value;
        return this;
    }
    public Phone SetColor(string value)
    {
        Color = value;
        return this;
    }
    public static Phone CreatedPhone()
    {
        return new Phone();
    }
    public override string ToString()
    {
        return $"{Model} - {Price} - {Size}  - {Color}";
    }
}