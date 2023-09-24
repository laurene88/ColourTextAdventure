using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{

    public GameObject exittingPanel;

    public void PressStartButton()
    {
        //take to main game.
        SceneManager.LoadScene(1);
    }

    public void PressExitButton()
    {
        exittingPanel.SetActive(true);
    }

    public void ExitYes(){
        Application.Quit();
    }

    public void ExitNo(){
         exittingPanel.SetActive(false);

    }

    public void PressEndingsButton(){
        SceneManager.LoadScene(3);
    }
}
