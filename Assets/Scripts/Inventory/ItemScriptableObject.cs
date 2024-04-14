using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Itemtype {Note, Keys, }
public class ItemScriptableObject : ScriptableObject
{
    public string itemName;
    public int maximumAmount;
    public GameObject itemPrefab;
    public Sprite icon;
    public Itemtype itemType;
    public string itemDescription;
}
