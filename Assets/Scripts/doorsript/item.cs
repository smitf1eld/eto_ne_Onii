using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;



public class item : MonoBehaviour
{
    public enum ItemType
    {
        Box,
        Test,
        Message,
        Key,
    }
    
    
    public ItemType type;
    private bool flag = false;
    public Text message = null;
    public string messageText;
    public GameObject obj = null;

    public void Interaction()
    {
        if (type == ItemType.Box)
        {
            flag = !flag;
            GetComponentInParent<Animator>().SetBool("Open", flag);
            GetComponentInParent<Animator>().SetBool("Close", flag);
        }

        if (type == ItemType.Test)
        {
            Destroy(gameObject);
        }

        if (type == ItemType.Message)
        {
            message.text = message.text;
        }

        if (type == ItemType.Key)
        {
            obj.GetComponent<item>().type = ItemType.Box;
            Destroy(gameObject);
        }
    }
}
