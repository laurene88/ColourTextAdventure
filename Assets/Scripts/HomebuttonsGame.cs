using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomebuttonsGame : MonoBehaviour
{
    [SerializeField] public GameObject homePanel;

    public void clickHome()
    {
        if (homePanel != null){
            homePanel.SetActive(true);
        }
        else clickYes();
    }

    public void clickYes()
    {
        homePanel.SetActive(false);
        SceneManager.LoadScene(0);
        EndingWriter.Instance.resetBooleans();
        }

    public void clickNo(){
        homePanel.SetActive(false);
    }
}
