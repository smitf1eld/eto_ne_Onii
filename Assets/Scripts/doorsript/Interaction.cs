using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Interaction : MonoBehaviour
{
    public Text indicator;
    public TextMeshPro messageText;
    
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2))
        {
            if (hit.collider.tag == "Item")
            {
                indicator.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.GetComponent<item>().Interaction();
                }

                if (hit.collider.GetComponent<item>().type != item.ItemType.Message)
                {
                    messageText.text = "";
                }
            }
            else
            {
                indicator.enabled = false;
                messageText.text = "";
            }
        }
        else
        {
            indicator.enabled = false;
            messageText.text = "";
        }
    }
}
