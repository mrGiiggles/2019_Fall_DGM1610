using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Fighters", menuName = "Chosen ones")]
public class Fighters : ScriptableObject
{
    public string figthingClass;
    public string name;

    public int health;
    public int mana;
    public int stamina;

    public int charisma;
    public int finesse;

    //public GameObject weapon;
}
