using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairSit : MonoBehaviour
{
    public GameObject player;
    public GameObject SitPosition;
    public GameObject resetPosition;
    public GameObject mouseIcon;

    [SerializeField] bool isSitting;

    private Interactable interact;
    Outline outline;
    MeshCollider mc;
    
    public CharacterController playerCC;

    // Start is called before the first frame update
    void Start()
    {
        interact = GetComponent<Interactable>();
       
        outline = GetComponent<Outline>();
        mc = GetComponent<MeshCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        if(outline.enabled == true && isSitting == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                player.transform.SetPositionAndRotation(SitPosition.transform.position, SitPosition.transform.rotation);
                isSitting = true;
                Debug.Log("Sit");
               
            }
        }
        if(outline.enabled == false && isSitting == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                player.transform.SetPositionAndRotation(resetPosition.transform.position, resetPosition.transform.rotation);
                isSitting = false;
                mc.enabled = true;
                playerCC.enabled = true;
            }

        }

        if(isSitting == true)
        {
            playerCC.enabled = false;
            mc.enabled = false;
            mouseIcon.SetActive(true);
        }else if (isSitting == false)
        {
            mouseIcon.SetActive(false);
        }
        

    }
}
