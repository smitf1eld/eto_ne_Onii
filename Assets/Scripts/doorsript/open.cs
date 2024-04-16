using UnityEngine;
using UnityEngine.EventSystems;

public class DoorController : MonoBehaviour
{
    public Canvas notice;
    public GameObject door;
    public Animator Animator;
    private bool inradius;
    public bool isopen;
    private int clikcount;


    private void OnTriggerEnter(Collider other)
    {
        inradius = true;
        clikcount = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        notice.gameObject.SetActive(false);
        inradius = false;
    }

    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (inradius)
        {
            notice.gameObject.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                Animator.SetBool("isopen", true);
                clikcount++;
            }

            if (clikcount >= 1) 
            {
                notice.gameObject.SetActive(false);
            }
        }
    }
}