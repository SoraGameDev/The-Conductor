using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenScript : MonoBehaviour
{
    public Transform playerRoot;
    public Transform screenPos;
    public Cinemachine.CinemachineVirtualCamera playerCam;

    public bool isLookingAt;

    private Interactable interact;
    public CharacterController playerCC;
    Outline outline;
    public StarterAssets.FirstPersonController fpc;
    public PlayerRaycast pr;
    public NotepadScript ns;

    // Start is called before the first frame update
    void Start()
    {
        interact = GetComponent<Interactable>();
        isLookingAt = false;
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (outline.enabled == true && isLookingAt == false)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                playerCam.m_Follow = screenPos.transform;
                isLookingAt = true;
                fpc.enabled = false;
                pr.enabled = false;
                playerCC.enabled = false;
                ns.lookingAtScreen = true;
            }
        }
        if (outline.enabled == false && isLookingAt == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                playerCam.m_Follow = playerRoot.transform;
                isLookingAt = false;
                fpc.enabled = true;
                playerCC.enabled = true;
                pr.enabled = true;
                ns.lookingAtScreen = false;
            }
        }



    }
}
