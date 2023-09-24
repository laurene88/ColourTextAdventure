using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingWriter : MonoBehaviour
{
// Keeps a note of all the impactful change choices made
// to write in the ending

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
public string endColour;


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

    return;
}


public void whatDidMuseumCuratorSay(string color){

}
//string leavingDisguiseString =  leavesDisguiseBool? "they left their disguises" : "we are unsure if they used disguises";
//"The famous 'Red' painting by the artist known as 'LXE' was stolen last night from the Central City Museum."

public void update()
{
    string storyline = choseWigs ? "the suspects left fake hair at the scene, suggesting teh use of wigs" : "the perps were all blonde";
    if (Input.GetKeyDown("space"))
    {
        Debug.Log(storyline);
    }
}

//COLOR
//CLOTHING
//PAINTED
//TOOK
}
