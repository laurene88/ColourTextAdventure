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
    public float endClickCount = 100.0f;
    public Color currentColor = Color.white;

    // References to all of the text in the scene.
    public TMP_Text questionTextBox;
    public TMP_Text b1;
    public TMP_Text b2;
    public TMP_Text b3;

    // Script Refrences
    public ButtonController buttonController;

    void Awake()
    {
        questionTextBox.color = new Color(1,1,1,1);
        // have buttons & get all text components
        buttonController = GetComponent<ButtonController>();
    }

    // 0 - red * opposite 180
    // 30 - orange
    // 60 - yellow ^
    // 90 - chartreuse green
    // 120 - green * opposite 300
    // 150 - spring green
    // 180 - cyan ^ 
    // 210 - azure
    // 240 - blue * opposite 60
    // 270 - violet
    // 300 - magenta ^
    // 330 - rose
    // %360

    // Color choice methods take a 'step' towards the appropriate color.
    // If currently at the exact color - don't take any step.
    // Red Hue is 0 and/or 360, Opposite is 180.
    public void RedChoice(int stepValue)
    {
        if (huePosition == 360 || huePosition == 0){
            // do nothing
        }
        else if (huePosition <=180){ // this is fine as half half. 
           MinusStep(stepValue); 
        } else {
            PlusStep(stepValue);
        }
        clickCount++;
        Debug.Log("HC choice red");
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
            Debug.Log("HC choice blue");
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
            Debug.Log("HC choice green");

    }


    // -----------------------------------------------------------------------
    // Moves the hue postiion (degree value) towards the appropriate color.
    // The size of the change (stepValue) is taken from the QuestionScriptable
    //  and passed to this method by ...*
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

    // Changes the color of all the TMP texts to the appropriate hue.
    public void UpdateHue()
    {
        saturation = clickCount/endClickCount;
        Debug.Log("hue:"+huePosition);
            // H, S, V all 0-1 values.
            //(hue/360, saturation/100, value/100)
            currentColor = Color.HSVToRGB(huePosition/360, saturation/10, value);
            questionTextBox.color = currentColor;
            b1.color = currentColor;
            b2.color = currentColor;
            b3.color = currentColor;
    }


    //Different ending text dependent on color block of text at final question. - 6 or 12 endings
    // RED
    // YELLOW
    // GREEN
    // CYAN
    // BLUE
    // PURPLE

    public void FakeEnd()
    {
        if (huePosition >90 && huePosition <150)
        questionTextBox.text = "GREEN ENDING";

        else if (huePosition <270  && huePosition >210 )
        questionTextBox.text = "BLUE ENDING";

        else 
          questionTextBox.text = "OTHER ENDING";

    }



    // Update is called once per frame
    void Update()
    {
        // Control Ending. (not really needed as Scriptables will control narrative.)
            if (clickCount >= endClickCount){
                FakeEnd();
               }

    }
}
