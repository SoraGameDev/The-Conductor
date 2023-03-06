using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    [SerializeField] float range = 5f;
    [SerializeField] LayerMask whatIsInteractable;
    public GameObject playerCam;
    public GameObject crosshair;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, range, whatIsInteractable))
        {
            Interactable interact = hit.transform.GetComponent<Interactable>();

            if(interact != null)
            {
                interact.isHit = true;
            }


            crosshair.SetActive(true);
            Debug.Log(hit.transform.name);
        }
        else
        {
            crosshair.SetActive(false);
            
        }

        

    }
}
