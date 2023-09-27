using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndSceneScript : MonoBehaviour
{
    //public GameObject endingManager;
    //public EndingWriter endingwriter;

    public TMP_Text canvasTextBox;
    private string endColor;
    public Color endHueColor;

    // Find ending manager & set reference to the ending writer script.
    void Start()
    { 
        endHueColor = EndingWriter.Instance.endHueColor;
        endColor = EndingWriter.Instance.endColor;
        changeText(endColor);
        //endingwriter = endingManager.GetComponent<EndingWriter>();
        //endcolor = endingwriter.getEndColor(); //TO DO HERE IS THE ISSUE. NEED TO DO EACH END.
        //endHueColor = endingwriter.getHue();
        canvasTextBox.color = endHueColor;
    }

    
    public void changeText(string color){
        switch (color)
        {
            case "Red":
            {
                canvasTextBox.text = "red END";
            }
            break;
            case "Yellow":
            {
            canvasTextBox.text = "yellow END";
            }
            break;
            case "Green":
            {
            canvasTextBox.text = "green END";
            }
            break;
             case "Cyan":
            {
            canvasTextBox.text = "cyan END";
            }
            break;
            case "Blue":
            {
            canvasTextBox.text = "blue END";
            }
            break;
            case "Magenta":
            {
            canvasTextBox.text = "magenta END";
            }
            break;
            default:
            canvasTextBox.text = "NO COLOR END";
            break;
        }

    }

}
