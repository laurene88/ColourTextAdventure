using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QuestionController : MonoBehaviour
{
    // Script references
    public ButtonController buttonController;
    public HueController hueController;

    // QuestionScriptable references
    public QuestionScriptable currentQS;
    public QuestionScriptable newQS;


    void Awake()
    {
        buttonController = GetComponent<ButtonController>();
        hueController = GetComponent<HueController>();
    }
    
    // Every button click calls this method, 
    // This sets the appropriate next question scriptable
    public void ButtonClicked(string colourPressed){
        // If the next question is the same regardless.
        if (currentQS.divergingScriptables == false && currentQS.nextSQ != null){
            newQS = currentQS.nextSQ;
        }

        // If the next question depends on the button pressed.
        if (currentQS.divergingScriptables == true){
            if (colourPressed == "Red")
            {
                newQS = currentQS.nextRedSQ;
            }
            if (colourPressed == "Blue")
            {
                newQS = currentQS.nextBlueSQ;
            }
            if (colourPressed == "Green")
            {
                newQS = currentQS.nextGreenSQ;
            }
        }
    }

    void Update()
    {
        // If new QS, change the text all of the buttons and questions display.
         if (currentQS.name != newQS.name)
          {
          buttonController.ResetBoxes(newQS);
        }
        currentQS = newQS;
    }

}
