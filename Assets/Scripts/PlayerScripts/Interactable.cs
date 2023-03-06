using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isHit;
    Outline outline;


    // Start is called before the first frame update
    void Start()
    {
        isHit = false;
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isHit)
        {
            outline.enabled = true;
            
        }
        else 
        { 
            outline.enabled = false;
            
        }
        isHit = false;
    }
}
