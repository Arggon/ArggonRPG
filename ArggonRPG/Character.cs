namespace ArggonRPG;

public class Character
{
    public Character(string name, CharacterClass @class)
    {
        Name = name;
        Class = @class;
        Id = GetNextId();
        Healt = 100;
        AddCharacter(this);
    }

    public Character()
    {
    }

    private int Id { get; set; }
    public string Name { get; set; }
    public int Healt { get; set; }
    public CharacterClass Class { get; set; }

    private static readonly List<Character> Characters = [];
    
    public static void AddCharacter(Character character)
    {
        Characters.Add(character);
    }

    public static List<Character> GetAllCharacters()
    {
        return Characters;
    }

    private static int GetNextId()
    {
        return Characters.Count + 1;
    }
}

public enum CharacterClass
{
    Warrior = 1,
}