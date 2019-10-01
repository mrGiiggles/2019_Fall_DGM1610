using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Adventurers", menuName = "Chosen ones")]
public class Adventurer : ScriptableObject
{
    public string figthingClass;
    public string name;

    public int health;
    public int mana;
    public int stamina;

    public int charisma;
    public int finesse;

    public GameObject weapon;
}
