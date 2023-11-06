using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "New Item")]

public class Items : ScriptableObject
{
    public int itemID;

    public string itemName;

    [TextArea(3, 3)] public string description;

    public enum Types
    {
        equipment,
        defence,
        attack,
        ammo,
        magic

    }

    public enum Rarity
    {
        common,
        uncommon,
        rare,
        epic
    }

    public GameObject prefab;
    public Texture icon;

    public Types type;
    public Rarity rarity;
    public int maxStack;
    public float weight;
    public int basevalue;
}
