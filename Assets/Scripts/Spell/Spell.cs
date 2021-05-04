public class Spell
{
    public string Name { get; private set; }
    public float Damage { get; private set; }

    public Spell(string name, float damage)
    {
        Name = name;
        Damage = damage;
    }
}