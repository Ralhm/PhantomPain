using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextAdvance : MonoBehaviour
{
    public TMP_Text textBox;
    public GameObject TableAdvanceButton;
    public GameObject nextButton;
    public GameObject backButton;
    public EventManager EM;
    public List<string> AnimalDialogue;
    public List<string> WhiteBoardDialogue;
    public List<string> TutorialDialogue;
    private List<string> CurrentDialogue;
    int DialogueCount = 0; //Int for keeping track of which dialogue we're in
    int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        CurrentDialogue = AnimalDialogue;
        textBox.text = CurrentDialogue[0];
    }

    public void NextText()
    {
        i++;
        if (i == CurrentDialogue.Count)
        {
            if (DialogueCount == 0) //Super Spaghetti, only doing this for expediency's sake
            {
                CurrentDialogue = WhiteBoardDialogue;
                SummonWhiteBoard();
            }
            else if (DialogueCount == 1)
            {
                CurrentDialogue = TutorialDialogue;
                SummonTutorial();
            }
            DialogueCount++;
            i = 0;
        }
        textBox.text = CurrentDialogue[i];
        
    }

    public void BackText()
    {
        if (i > 0)
        {
            i--;
            textBox.text = CurrentDialogue[i];
        }
        
    }


    
    public void SummonWhiteBoard() //Event for moving onto the next play style
    {
        EM.StartCoroutine(EM.WhiteBoardEaseIn(-1.0f));
    }

    public void SummonTutorial() //Event for moving onto the next play style
    {
        EM.StartCoroutine(EM.TutorialEaseIn(1.0f));
    }
}
