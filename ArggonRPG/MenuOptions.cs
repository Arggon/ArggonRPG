namespace ArggonRPG;

public class MenuOptions
{
    public MenuOptions(int id, string description)
    {
        Id = id;
        Description = description;
    }

    public int Id { get; set; }
    public string Description { get; set; }
}