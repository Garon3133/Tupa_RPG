using System.Collections.Generic;
using UnityEngine;

public class Character : ICharacter
{
    private enum State
    {
        Alive,
        Death
    }

    private State state = State.Alive;
    
    public string Name { get; private set; }
    
    public float MaxHealth { get; private set; }
    public float CurrentHealth { get; private set; }
    private const float minHealth = 0.0f;
    
    public int Level { get; private set; }
    private const int maxLevel = 100;
    private const int minLevel = 1;
    
    public float CurrentExp { get; private set; }
    public float MaxExp { get; private set; }
    private const float minExp = 0.0f;
    
    public float Damage { get; private set; }

    public List<Spell> Spells { get; private set; }

    public Character(string name, float currentHealt, int level, float currentExp, float damage, List<Spell> spells)
    {
        Name = name;
        CurrentHealth = currentHealt;
        MaxHealth = currentHealt;
        Level = level;
        CurrentExp = currentExp;
        MaxExp = 100;
        Damage = damage;
        Spells = spells;
    }

    public void GetInfo()
    {
        Debug.Log($"NAME: {Name}\nSTATE: {state}\n" + 
                  $"HEALTH: {CurrentHealth}/{MaxHealth}\nEXP: {CurrentExp}/{MaxExp}\nLEVEL: {Level}");
        foreach (var spell in Spells)
        {
            Debug.Log($"Спел: {spell.Name} Дамаг: {spell.Damage}");
        }

        Debug.Log("=================================");
    }

    public void Heal(float health)
    {
        CurrentHealth += health;
        if (health >= MaxHealth)
            CurrentHealth = MaxHealth;
    }

    public void TakeExp(float exp)
    {
        CurrentExp += exp;
        if (CurrentExp >= MaxExp)
        {
            Level++;
            CurrentExp -= MaxExp;
        }
    }

    public void GiveDamage(Character character)
    {
        character.TakeDamage(Damage);
    }

    public void TakeDamage(float damage)
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0) Die();
    }

    public void CastTargetSpell(Character targetCharacter, int id)
    {
        targetCharacter.TakeDamage(Spells[id].Damage);
    }

    public void CastUnTargetSpell(int id)
    {
        Debug.Log($"Cast UnTarget Spell {Spells[id].Name}");
    }

    public void Die()
    {
        Debug.Log($"Умер: {Name}");
        state = State.Death;
    }
}