using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour
{
    Outline outline;
    public GameObject paper;

    public CharacterController playerCC;
    public StarterAssets.FirstPersonController fpc;
    public ApartmentDoor apDoor;

    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if(outline.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                paper.SetActive(true);
                Destroy(gameObject);
                playerCC.enabled = false;
                fpc.enabled = false;
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

  
}
