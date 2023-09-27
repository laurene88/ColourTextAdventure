using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingWriter : MonoBehaviour
{
// Keeps a note of all the impactful change choices made
// to write in the ending
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

// Strings
public string endColor;

public Color endHueColor;

public void Start()
{
    huecontroller = gm.GetComponent<HueController>();
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
        //GO TO END SCENES
        endHueColor = huecontroller.getHueColor();
        huecontroller.GiveEndColor();
        DontDestroyOnLoad(this); // TO DO dont want more than 1 ending writer, dont want 
        SceneManager.LoadScene("EndScene");
    }

    return;
}


public void setEndColor(string color){
    endColor = color;
}

public string getEndColor()
{
    return endColor;
}

public Color getHue(){
    return endHueColor;
}
//COLOR
//CLOTHING
//PAINTED
//TOOK
}
