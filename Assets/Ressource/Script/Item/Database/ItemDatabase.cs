using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemDatabase", menuName = "Database/ItemDatabase", order = 0)]
public class ItemDatabase : ScriptableObject
{
    public Item[] item;
}

