using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        var elf = new Character("Elf", 10.0f, 1, 0.0f, 10.0f,
            new List<Spell>()
            {
                new Spell("FireBall", 15.0f),
                new Spell("GarbageBall", 12.0f),
                new Spell("EarthSpikes", 20.0f),
            });
        var orc = new Character("Orc", 35.0f, 1, 0.0f, 7.0f,
            new List<Spell>()
            {
                new Spell("SwordPunch", 9.0f),
                new Spell("SwordBlink", 8.0f),
                new Spell("BloodSeek", 7.0f),
            });
    }
}