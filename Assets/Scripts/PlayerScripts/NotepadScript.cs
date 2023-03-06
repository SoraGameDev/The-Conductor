using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotepadScript : MonoBehaviour
{
    //public List<ScreenScript> screens;
    public GameObject notepadUI;
    public GameObject notepadPrompt;

    public bool lookingAtScreen = false;
    public bool isEditing;
    public string textToEdit;
    public Rect textRect;
    public GameObject textBox;
    public TextMeshProUGUI noteText;
    public Font font;

    // Start is called before the first frame update
    void Start()
    {
        textRect = textBox.GetComponent<Rect>();
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (lookingAtScreen == true && Input.GetKeyDown(KeyCode.R) && isEditing == false)
        {
            isEditing = true;
            notepadUI.SetActive(true);
            notepadPrompt.SetActive(false);
            Cursor.lockState = CursorLockMode.None;
            
        }
        if(lookingAtScreen == true && isEditing == false)
        {
            notepadPrompt.SetActive(true);
        }else if (lookingAtScreen == false)
        {
            notepadPrompt.SetActive(false);
        }
        if(isEditing == false)
        {
            notepadUI.SetActive(false);
            textToEdit.Replace(textToEdit," ");
        }
    }

    public void CloseNotepad()
    {
        isEditing = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

   
}
