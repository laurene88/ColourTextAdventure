using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomebuttonsGame : MonoBehaviour
{
    [SerializeField] public GameObject homePanel;
    public GameObject endingManager;

    public void Start()
    {
        endingManager = GameObject.Find("EndingManager");
    }
    public void clickHome()
    {
        if (homePanel != null){
            homePanel.SetActive(true);
        }
        else clickYes();
    }

    public void clickYes()
    {
        SceneManager.LoadScene(0);
        if (endingManager != null){
            Destroy(endingManager); // TO DO pehaps get rid of this, just reset/rewrite?
        }
        }

    public void clickNo(){
        homePanel.SetActive(false);
    }
}
