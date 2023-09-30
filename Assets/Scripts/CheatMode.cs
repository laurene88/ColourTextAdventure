using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheatMode : MonoBehaviour
{
    public GameObject redButton;
    public GameObject blueButton;
    public GameObject greenButton;
    public Color startColor = new Color(0.2196079f, 0.2313726f, 0.2745098f, 1f);


    // The below code is taken/modified from Unity
    // https://docs.unity3d.com/2019.1/Documentation/ScriptReference/UI.Toggle-onValueChanged.html
    Toggle m_Toggle;

    void Start()
    {
        //Fetch the Toggle GameObject
        m_Toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
        m_Toggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(m_Toggle);
        });

    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {
        if (m_Toggle.isOn){
           //redButton.GetComponent<Image>().color = new Color(0.5754717f, 0.1284858f, 0.1415045f, 1);
            redButton.GetComponent<Image>().color = Color.red;
            blueButton.GetComponent<Image>().color = Color.blue;
            greenButton.GetComponent<Image>().color = Color.green;
        }

        else {
            redButton.GetComponent<Image>().color = startColor;
            blueButton.GetComponent<Image>().color = startColor;
            greenButton.GetComponent<Image>().color = startColor;
        }
    }
}
