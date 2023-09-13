using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingWriter : MonoBehaviour
{
// Keeps a note of all the impactful change choices made
// to write in the ending

// Booleans
public bool leavesDisguiseBool;
public bool leftPaint;
public bool tookExtra;
public bool securityFootageTaken;

// Strings
public string entrance;
public string endColour;
public string museumCuratorSaid;



// Called from the ButtonController, passes Question Controller, scriptable information.
public void HasImpactfulChange(string QSname, string color)
{
    if (QSname == "04" && color == "Red"){
        leavesDisguiseBool = true;
    }

    return;
}

public void whatDidMuseumCuratorSay(string color){

}
//string leavingDisguiseString =  leavesDisguiseBool? "they left their disguises" : "we are unsure if they used disguises";
//"The famous 'Red' painting by the artist known as 'LXE' was stolen last night from the Central City Museum."

}