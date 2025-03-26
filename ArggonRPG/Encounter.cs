namespace ArggonRPG;

public class Encounter
{
    private static readonly List<Encounter> Encounters = [];
    public Encounter(Character character, Enemy enemy)
    {
        Character = character;
        Enemy = enemy;
        AddEncounter(this);
    }

    public Encounter()
    {
    }

    public Character Character { get; }
    public Enemy Enemy { get; }
    public bool IsVictory { get; set; }
    
    private static void AddEncounter(Encounter encounter)
    {
        Encounters.Add(encounter);
    }
    
    public static List<Encounter> GetAllEncounters()
    {
        return Encounters;
    }

    public void CharacterAttack()
    {
        Console.WriteLine("Atacando al enemigo...");
        Console.WriteLine($"Has atacado al {Enemy.Name}. Salud restante del enemigo: {Enemy.Health}");
    }
}