using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingsPageScript : MonoBehaviour
{
    public GameObject redFrame;
    public GameObject yellowFrame;
    public GameObject greenFrame;
    public GameObject cyanFrame;
    public GameObject blueFrame;
    public GameObject magentaFrame;


    public void Start()
    {
        if (EndingWriter.Instance.RedDone == true){
            RedDone();
        }
        
        if (EndingWriter.Instance.YellowDone == true){
            YellowDone();
        }
        
        if (EndingWriter.Instance.GreenDone == true){
        GreenDone();
        }

        if (EndingWriter.Instance.CyanDone == true){
        CyanDone();
        }
        
        if (EndingWriter.Instance.BlueDone == true){
        BlueDone();
        }
        
        if (EndingWriter.Instance.MagentaDone == true){
        MagentaDone();
        }
    }


    // Changes the frame/text colours if colour is completed.
    public void RedDone(){
        SpriteRenderer framesr = redFrame.GetComponent<SpriteRenderer>();
      framesr.color = new Color(1,0,0,1);
      
        TMP_Text redtext = redFrame.GetComponentInChildren<TMP_Text>();
        redtext.color = new Color (1,0,0,1);
    }

    
    public void YellowDone(){
        SpriteRenderer framesr = yellowFrame.GetComponent<SpriteRenderer>();
        framesr.color = new Color(1,0.92f,0.016f,1);
      
        TMP_Text yellowtext = yellowFrame.GetComponentInChildren<TMP_Text>();
        yellowtext.color = new Color (1,0.92f,0.016f,1);
    }

    
    public void GreenDone(){
        SpriteRenderer framesr = greenFrame.GetComponent<SpriteRenderer>();
      framesr.color = new Color(0,1,0,1);
      
        TMP_Text text = greenFrame.GetComponentInChildren<TMP_Text>();
        text.color = new Color (0,1,0,1); 
    }

    
    public void CyanDone(){
        SpriteRenderer framesr = cyanFrame.GetComponent<SpriteRenderer>();
      framesr.color = new Color(0,1,1,1);
      
        TMP_Text text = cyanFrame.GetComponentInChildren<TMP_Text>();
        text.color = new Color (0,1,1,1); 
    }

    
    public void BlueDone(){
        SpriteRenderer framesr = blueFrame.GetComponent<SpriteRenderer>();
        framesr.color = new Color(0,0,1,1);
      
        TMP_Text text = blueFrame.GetComponentInChildren<TMP_Text>();
        text.color = new Color (0,0,1,1); 
    }

    
    public void MagentaDone(){
        SpriteRenderer framesr = magentaFrame.GetComponent<SpriteRenderer>();
        framesr.color = new Color(1,0,1,1);
      
        TMP_Text text = magentaFrame.GetComponentInChildren<TMP_Text>();
        text.color = new Color (1,0,1,1); 
    }
}
