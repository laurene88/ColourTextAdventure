using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HueController : MonoBehaviour
{
    // Initial HSV values. Hue set to 0, will be changed after first question.
    public float huePosition = 0;
    public float saturation = 0.0f;
    public float value = 1;

    public int clickCount = 0;
    public float topClickCount = 18f; // Relates to maximum saturation
    public static int endClickCount = 25; // Relates to the end of the game
    public Color currentColor = Color.white;

    // References to all of the text in the scene.
    public TMP_Text questionTextBox;
    public TMP_Text b1text;
    public TMP_Text b2text;
    public TMP_Text b3text;

    // Script Refrences
    public ButtonController buttonController;

    void Awake()
    {
        //questionTextBox.color = currentColor;
        // have buttons & get all text components
        buttonController = GetComponent<ButtonController>();
    }

    void Start(){
        currentColor = Color.white;
    }

    //---------------------------------------------------------------------------
    // HUE INFORMATION
    //---------------------------------------------------------------------------
    // Color.HSVToRGB(hue, saturation, value)
    // H S V are all 0-1 values.
    //(hue/360, saturation, value)

    // Degree information on each color:
    // 0 - red * opposite 180 (330-0-30)
    // 30 - orange
    // 60 - yellow ^ (30-90)
    // 90 - chartreuse green
    // 120 - green * opposite 300 (90-150)
    // 150 - spring green
    // 180 - cyan ^ (150-210)
    // 210 - azure
    // 240 - blue * opposite 60 (210-270)
    // 270 - violet
    // 300 - magenta ^ (270-330)
    // 330 - rose
    // %360


    //---------------------------------------------------------------------------
    // Color Choice Methods.
    //      Color choice methods take a 'step' towards the color button chosen.
    //      If currently at the exact color - don't take any step.
    //---------------------------------------------------------------------------

    // Red Hue is 0 and/or 360, Opposite is 180.
    public void RedChoice(int stepValue)
    {
        if (huePosition == 360 || huePosition == 0){
            // do nothing
        }
        else if (huePosition <=180){
           MinusStep(stepValue); 
        } else {
            PlusStep(stepValue);
        }
        clickCount++;
        UpdateHue();
    }

    //Blue Hue is 240, Opposite is 60
    public void BlueChoice(int stepValue)
    {
        if (huePosition == 240){
            // do nothing
        }
        else if (huePosition > 60 && huePosition <=240)
        {
            PlusStep(stepValue);
        } else {
            MinusStep(stepValue);
        }
        clickCount++;
        UpdateHue();
    }

    // Green Hue is 120, Opposite is 300.
    public void GreenChoice(int stepValue)
    {
        if (huePosition == 120){
            // do nothing
        }
        else if (huePosition >120 && huePosition <=300){
            MinusStep(stepValue);
        } else {
            PlusStep(stepValue);
        }
        clickCount++;
        UpdateHue();

    }


    // -----------------------------------------------------------------------
    // Step Methods.
    //      Moves the hue postiion (degree value) in the right direction.
    //      +360 %360 to account for circular nature of Hues.
    //      Plus step/Minus step move around the circle in different directions.
    //      The size of the change (stepValue) is taken from the QuestionScriptable
    //      itself and passed to this method by the Button Controller.
    // -----------------------------------------------------------------------

    // (current position (+ or - step) +360) %360
    public void PlusStep(int stepValue)
    {
        huePosition = (huePosition + stepValue + 360)%360;
    }

    public void MinusStep(int stepValue)
    {
        huePosition = (huePosition - stepValue + 360)%360;
    }


    // Changes the color of all the TMP texts to the appropriate new hue.
    public void UpdateHue()
    {
        saturation = clickCount/topClickCount;
       // Debug.Log("updatnig hue- clickcount:"+clickCount+"saturation:"+saturation+"hueposition:"+huePosition);
            currentColor = Color.HSVToRGB(huePosition/360, saturation, value);
            questionTextBox.color = currentColor;
            b1text.color = currentColor;
            b2text.color = currentColor;
            b3text.color = currentColor;
    }


    //Different ending text dependent on color block of text at final question. - 6 or 12 endings
    public void FakeEnd()
    {
        //choice buttons fade out and then are destroyed.
        // text fades out then changes to ending text and fades back in?
        Debug.Log(huePosition);
        if (huePosition >=0  && huePosition <=30)
            questionTextBox.text = "FAMED 'RED' PAINTING STOLEN";
    
        if (huePosition > 30  && huePosition <=90)
            questionTextBox.text = "FAMED 'YELLOW' PAINTING STOLEN";
    
        if (huePosition >90 && huePosition <=150)
            questionTextBox.text = "FAMED 'GREEN' PAINTING STOLEN";

        if (huePosition >150 && huePosition <=210)
        questionTextBox.text = "FAMED 'CYAN' PAINTING STOLEN";

        if (huePosition >210  && huePosition <=270)
        questionTextBox.text = "FAMED 'BLUE' PAINTING STOLEN";

        if (huePosition >270 && huePosition <= 330)
          questionTextBox.text = "FAMED 'MAGENTA' PAINTING STOLEN";

        if ((huePosition >330) && (huePosition <= 360))
          questionTextBox.text = "FAMED 'RED' PAINTING STOLEN(330-360)";  
    }



    // Update is called once per frame
    void Update()
    {
        // Control Ending. (not really needed as Scriptables will control narrative.)
          //  Debug.Log(clickCount+":"+endClickCount);
            if (clickCount == endClickCount){
                FakeEnd();
               }
    }
}
