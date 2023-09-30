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
    public static float topClickCount = 22.0f; // Relates to maximum saturation
    public Color currentColor = Color.white;
    public int clickCount = 0;
      
   
    // References to all of the text in the scene.
    public TMP_Text questionTextBox;
    public TMP_Text b1text;
    public TMP_Text b2text;
    public TMP_Text b3text;

    // Script Refrences
    public ButtonController buttonController;
 

    void Awake()
    {
        buttonController = GetComponent<ButtonController>();
    }

    void Start()
    {
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
        else if (huePosition != 0 && huePosition <=180){
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
        //Debug.Log("clicks: "+clickCount+"saturation: "+saturation+"hueposition: "+huePosition);
            currentColor = Color.HSVToRGB(huePosition/360, saturation, value);
            questionTextBox.color = currentColor;
            b1text.color = currentColor;
            b2text.color = currentColor;
            b3text.color = currentColor;
    }

    public Color GetHueColor()
    {
        return currentColor;
    }


    // Different string of colour name dependent on final hue, each 6 is a different ending.
  public string GetEndColor()
   {
         if (huePosition >=0  && huePosition <=30){
            return ("Red");
         }
    
         else if (huePosition > 30  && huePosition <=90){
            return ("Yellow");
        }
    
        else if (huePosition >90 && huePosition <=150){
              return ("Green");
         }

         else if (huePosition >150 && huePosition <=210){
          return ("Cyan");
         }

         else if (huePosition >210  && huePosition <=270){
         return "Blue";
         }

         else if (huePosition >270 && huePosition <= 330){
            return ("Magenta");
         }

        else if (huePosition >330 && huePosition <= 360){
            return ("Red");
        }
        else return ("ohno");
     }

}
