using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[CreateAssetMenu]
public class QuestionScriptable : ScriptableObject
{
    // Main text for the story/question.
    [TextAreaAttribute(5,50)]
    public string question;
    

    // Button options with default string of the buttons color.
    public string optionRed = "red";
    public string optionBlue = "blue";
    public string optionGreen = "red";


    // Scriptable holds its own hue change step value, default 5.
    public int specialStepValue = 5;


    // Boolean, does this question lead to different question based on the answer chosen.
    public bool divergingScriptables;
    public bool hasImpactfulChange;


    // Links to next question scriptables for all answer selections.
    public QuestionScriptable nextSQ;
    public QuestionScriptable nextRedSQ;
    public QuestionScriptable nextBlueSQ;
    public QuestionScriptable nextGreenSQ;

}
