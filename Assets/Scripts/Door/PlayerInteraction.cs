using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class NewBehaviourScript : MonoBehaviour
{
    public Camera Maincam;
    public float interactionDistance = 10f;

    
    public TextMeshProUGUI interactionText;
    void Update()
    {
        InteractionRay();
    }

    void InteractionRay()
    {
        Ray ray = Maincam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitsomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance ))
        {
            IInteractiable interactiable = hit.collider.GetComponent<IInteractiable>();

            if (interactiable !=null)
            {
                hitsomething = true;
                interactionText.text = interactiable.GetDescription();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactiable.Interact();
                }
            }
        }
        
        
    }
}
