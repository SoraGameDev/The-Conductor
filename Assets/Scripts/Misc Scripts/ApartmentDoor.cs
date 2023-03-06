using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApartmentDoor : MonoBehaviour
{
    public bool LetterRead = false;
    [SerializeField] int mainScene;
    Outline outline;

    public GameObject paper;
    public StarterAssets.FirstPersonController fpc;
    public CharacterController playerCC;

    public Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // Update is called once per frame
    void Update()
    {
        if (outline.enabled == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                if (LetterRead == false)
                {

                }
                
                if (LetterRead == true)
                {
                    animator.SetTrigger("DoorOpen");
                    Invoke(nameof(GoToMain), 5f);
                    outline.enabled = false;
                }
            }



        }
    }
       
        public void CloseLetter()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            playerCC.enabled = true;
            fpc.enabled = true;
            paper.SetActive(false);
            LetterRead = true;
        }
    
    void GoToMain()
    {
        SceneManager.LoadScene(2);
    }
}
