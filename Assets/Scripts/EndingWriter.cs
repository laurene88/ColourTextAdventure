using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingWriter : MonoBehaviour
{
    //Singleton pattern
    public static EndingWriter Instance;

// Keeps a note of all the impactful change choices made to 
//     to write in the ending
public GameObject gm;
public HueController huecontroller;

// Booleans
public bool choseHats;
public bool choseWigs;
public bool choseBalaclavas;
public bool sprayedPolitical;
public bool sprayedSymbol;
public bool leftPaint;
public bool tookMany;
public bool tookTwo;


//Ending Booleans - Which of the endings have been earned.
public bool RedDone;
public bool YellowDone;
public bool GreenDone;
public bool CyanDone;
public bool BlueDone;
public bool MagentaDone;


// END DATA Strings
public string endColor; // which of the 6 endings you get.
public Color endHueColor; // hue to set text color to.


private void Awake()
{
    // Sets up singleton instance of endingWriter.
    // (Removes audio if double up of endingManager)
    if (Instance != null)
    {
        Destroy(this);
        Destroy(this.GetComponent<AudioSource>());
        return;
    } else {
    Instance = this;
    DontDestroyOnLoad(this);
    }
}


public void Update()
{
    if (gm == null){ // In update so can find GM in new scenes.
    gm = GameObject.Find("GM"); 
    huecontroller = gm.GetComponent<HueController>();
    }
}

// Sets all storyline bools to false.
public void resetBooleans(){
    choseHats = false;
    choseWigs = false;
    choseBalaclavas = false;
    sprayedPolitical = false;
    sprayedSymbol = false;
    leftPaint = false;
    tookMany = false;
    tookTwo = false;
}


// Called from the ButtonController, passes Question Controller, scriptable information.
public void HasImpactfulChange(string QSname, string color)
{
    if (QSname == "09" && color == "Red"){
       //hat & dark glasses
       choseHats = true;
    }
    
    if (QSname == "09" && color == "Blue"){
        //balaclavas
        choseBalaclavas = true;
    }
    if (QSname == "09" && color == "Green"){
        //wigs
        choseWigs = true;
    }

  if (QSname == "SprayGroupSymbol" && color == "Red"){
      //sprayed A&T symbol
        sprayedSymbol = true;
        leftPaint = true;
      }     

  if (QSname == "SprayGroupSymbol" && color == "Green"){
      //sprayed square symbol
      sprayedSymbol = true;
      leftPaint = true;
      }     

  if (QSname == "SprayPoliticalSymbol" && color == "Red"){
      //sprayed abotu returning art
      sprayedPolitical = true;
      leftPaint = true;
      } 

if (QSname == "SprayPoliticalSymbol" && color == "Green"){
      //sprayed about politics
         sprayedPolitical = true;
         leftPaint = true;
      }   
    
if (QSname == "WhichPieces" && color == "Red"){
        tookTwo = true;
        }

if (QSname == "WhichPieces" && color == "Green"){
        tookMany = true;
        }
    

    if (QSname == "TakeMore" && color == "Green"){
        tookMany = true;
    }

    if (QSname == "last"){
        endColor = huecontroller.GetEndColor();
        whichColorDone(endColor); 
        endHueColor = huecontroller.GetHueColor();
        SceneManager.LoadScene("EndScene");
    }
    return;
}


public void whichColorDone(string endColor)
{
    switch (endColor){
        case "Red":
            RedDone = true;
            break;
        case "Yellow":
            YellowDone = true;
            break;
        case "Green":
            GreenDone = true;
            break;
        case "Cyan":
            CyanDone = true;
            break;
        case "Blue":
            BlueDone = true;
            break;
        case "Magenta":
            MagentaDone = true;
            break;
        default: 
        break;
    }
}

}
