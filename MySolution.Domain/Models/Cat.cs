namespace MySolution.Domain;

public class Cat
{
    public string Name { get; set; }
    public string Color { get; set; }
    public string Breed { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.Now; 

}
