using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="Note Item",menuName ="Inventory/Items/New Note Item")]
internal class NoteItem : ItemScriptableObject
{
    private void Start()
    {
        itemType = Itemtype.Note;
    }
}

