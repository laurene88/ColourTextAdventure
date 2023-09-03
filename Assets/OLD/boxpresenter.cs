using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boxpresenter : MonoBehaviour
{
    public QuestionScriptable currentQS;
    public QuestionScriptable newQS;
    
    public TMP_Text QuestionText;
    public TMP_Text[] textBoxes = new TMP_Text[3];

    // Get the correct Question scriptable
    //(or be given it by the GM.)


    // Shuffle the order of texts inplace in the text array.
    public void FisherYatesShuffle(TMP_Text[] ta)
    {
        for (int i = ta.Length-1; i>0; i--){
            int index = Random.Range(0,2);
            if (i != index){ //if a different place
                (ta[i], ta[index]) = (ta[index], ta[i]); // swap them
            }
        }

    }

    // Start is called before the first frame update
    void Start()
    {
    ResetBoxTexts();
       //for (int i = 0; i<10; i++){

        //Debug.Log(textBoxes[0].text + textBoxes[1].text + textBoxes[2].text);
        }
    
 // public TMP_Text[] OptionsArray = {optionRed, optionGreen, optionBlue};

    public void ResetBoxTexts()
    {
        QuestionText.text = newQS.question;
        FisherYatesShuffle(textBoxes);
        textBoxes[0].text = newQS.optionRed;
        textBoxes[1].text = newQS.optionGreen;
        textBoxes[2].text = newQS.optionBlue;
        currentQS = newQS;
    }

    // Update is called once per frame
    void Update()
    {
        //if new question scriptable is not same as current, update boxes.
          if (newQS.name != currentQS.name)
          {
            ResetBoxTexts();
          }

        }

        
    }