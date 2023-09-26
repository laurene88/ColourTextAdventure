using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{
    // Button Location references
    public GameObject button1location;
    public GameObject button2location;
    public GameObject button3location;
    public GameObject[] buttonLocations;

    //Buttons and Main question textbox.
    public TMP_Text questionTextBox;
    public Button RedButton;
    public Button BlueButton;
    public Button GreenButton;

    // Script References
    public HueController hueController;
    public QuestionController questionController;
    public GameObject endingManager;
    public EndingWriter endingWriter;

    public void Awake()
    {
        //could find all buttons and their text objects?
        buttonLocations = new GameObject[] {button1location, button2location, button3location};
        hueController = GetComponent<HueController>();
        questionController = GetComponent<QuestionController>();
        endingWriter = endingManager.GetComponent<EndingWriter>();
    }


    // Get the correct Question scriptable
    //(or be given it by the GM.)

    // Shuffles the button LOCATIONS in the list.
    public void FisherYatesShuffle(GameObject[] b)
    {
        for (int i = b.Length-1; i>0; i--){
            int index = Random.Range(0,2);
            if (i != index){ //if a different place
                (b[i], b[index]) = (b[index], b[i]); // swap them
            }
        }

    }

    // Method is given the correct new QuestionScriptable by the QuestionController.   
    public void ResetBoxes(QuestionScriptable newQS)
    {
        //replace the question text.
        if (questionTextBox != null){
        questionTextBox.text = newQS.question;
        }

        //Change button texts to reflect new questions.
        RedButton.GetComponentInChildren<TMP_Text>().text = newQS.optionRed;
        GreenButton.GetComponentInChildren<TMP_Text>().text = newQS.optionGreen;
        BlueButton.GetComponentInChildren<TMP_Text>().text = newQS.optionBlue;

        // Shuffle button positions
        FisherYatesShuffle(buttonLocations);
        RedButton.transform.position = buttonLocations[0].transform.position;
        BlueButton.transform.position = buttonLocations[1].transform.position;
        GreenButton.transform.position = buttonLocations[2].transform.position;
        
    }

    // When a button is clicked:
    // - Pass the click and the color of the button to the Hue Controller
    // - Pass the click and the color of the button to the Question Controller
    // EXCEPT where the button is 'special' as has different Hue change settings.
    public void ClickRed()
    {
        hueController.RedChoice(questionController.currentQS.specialStepValue);
        questionController.ButtonClicked("Red");
        // If button has impactful change on ending result
        if (questionController.currentQS.hasImpactfulChange) {
           endingWriter.HasImpactfulChange(questionController.currentQS.name, "Red");

        }
    }

    public void ClickBlue()
    { 
        hueController.BlueChoice(questionController.currentQS.specialStepValue);
        questionController.ButtonClicked("Blue");
        // If button has impactful change on ending result
        if (questionController.currentQS.hasImpactfulChange) {
           endingWriter.HasImpactfulChange(questionController.currentQS.name, "Blue"); 
           }
    }

    public void ClickGreen()
    {        
        hueController.GreenChoice(questionController.currentQS.specialStepValue);
        questionController.ButtonClicked("Green");
        // If button has impactful change on ending result
        if (questionController.currentQS.hasImpactfulChange) {
           endingWriter.HasImpactfulChange(questionController.currentQS.name, "Green");
        }
    }



}
