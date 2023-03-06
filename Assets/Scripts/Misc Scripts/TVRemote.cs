using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVRemote : MonoBehaviour
{
    bool tvOn = true;
    
    
    private Interactable interactable;
    Outline outline;


    public GameObject staticScreen;
    public GameObject blankScreen;



    // Start is called before the first frame update
    void Start()
    {
        interactable = GetComponent<Interactable>();
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (outline.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                tvOn = tvOn ? false : true;
                
            }
        }

        if(tvOn == true)
        {
            staticScreen.SetActive(true);
            blankScreen.SetActive(false);

        }else if (tvOn == false)
        {
            staticScreen.SetActive(false);
            blankScreen.SetActive(true);
        }
    }
}
