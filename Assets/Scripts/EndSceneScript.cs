using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndSceneScript : MonoBehaviour
{
    public TMP_Text canvasTextBox;
    private string endColor;
    public Color endHueColor;
    public string sprayText;
    public string tookText;
    public string outfitText;

    /// <summary>
    /// Accesses game information from EndingWriter Instance
    /// Uses this to set ending, hue, and text based on color and specific game choices.
    /// </summary>

    void Start()
    { 
        endHueColor = EndingWriter.Instance.endHueColor;
        endColor = EndingWriter.Instance.endColor;
        chooseSprayText();
        chooseTookText();
        chooseOutfitText();
        changeText(endColor);
        canvasTextBox.color = endHueColor;
    }

    public void chooseSprayText(){
        if (EndingWriter.Instance.leftPaint){
            sprayText = EndingWriter.Instance.sprayedPolitical? "Brazenly, the thieves also sprayed paint on the walls of the museum, alluding to a political motive.":
             "Daringly, the thieves were bold enough to spray paint on the walls of the museum before leaving. Police have indicated they sprayed a kind of symbol, believed to be related to their criminal ring.";
        }
        else sprayText = "The thieves left little trace behind. It is assumed the thieves hope to gain financially from selling the painting on the black market";
    }

    public void chooseTookText(){
        if (EndingWriter.Instance.tookMany == true){
           tookText = "Although they entered silently, while inside it was essentially a free for all with numerous pieces taken.";
        }
        if (EndingWriter.Instance.tookTwo == true){
            tookText = "The painting was not the only item taken, with the museum to confirm the other missing pieces at a later time.";
        }
        else tookText = "The painting was the only item stolen, suggesting a very targetted theft which was likely planned beforehand.";
    }
    
    public void chooseOutfitText(){
        if (EndingWriter.Instance.choseWigs){
            outfitText = "There was no witnesses to the break-in, however there was a hair left at the scene which the police laboratory will be attempting to identify.";
        }
        if (EndingWriter.Instance.choseHats){
            outfitText = "As of yet, the police have not spoken to any witesses, and anyone who was in the area between 1 and 3am is asked to come forward with any information.";
        }
        else outfitText = "Witnesses that happened to be walking home at approximately 2:30am saw multiple people wearing balaclavas jumping the back fence of the museum.";
    }
    public void changeText(string color){
        switch (color)
        {
            case "Red":
            {
                canvasTextBox.text = "<b><size=150%>FAMED 'RED' PAINTING STOLEN </b><br><br>"
                    +"<size=100%>The famous solid-colour painting 'RED' by the artist known only as 'colOUR' was stolen last night from its display at the town museum. <br><br>"
                    +"This scandalous theft has rocked the town. <br>"
                    +"It is believed that this was the work of a group of thieves who entered under the cover of night. Likely between 1 and 3am - when the museums alarms and security system were turned off. <br><br> "
                    +outfitText+" "+tookText+" "+sprayText+"<br><br>"
                    +"The museum curator stated 'This is a very sad day for the museum. "
                    +"This theft will go down in the history books, we have never had such a roguish theft and its extremely disappointing. This is a big loss. <br>"
                    +"<br>The town museum will be closed to the public until the police have concluded their scene investigation.";
            }
            break;
            case "Yellow":
            {
            canvasTextBox.text = "<b><size=150%>FAMED 'YELLOW' PAINTING STOLEN </b><br><br><size=100%>"
                    +"<size=100%>The famous solid-colour painting 'YELLOW' by the artist known only as 'colOUR' was stolen last night from its display at the town museum. <br><br>"
                    +"This deplorable theft has rocked the town. <br>"
                    +"It is believed that this was the work of a group of thieves who entered under the cover of night. Likely between 1 and 3am - when the museums alarms and security system were turned off. <br><br> "
                    +outfitText+" "+tookText+" "+sprayText+"<br><br>"
                    +"The museum curator stated 'This is a very sad day for the museum. We have never had such a robbery at this museum "
                    +"These thieves are obviously tenacious and it is very worrying for other galleries. <br>"
                    +"<br>The town museum will be closed to the public until the police have concluded their scene investigation.";
            }
            break;
            case "Green":
            {
            canvasTextBox.text = "<b><size=150%>FAMED 'GREEN' PAINTING STOLEN </b><br><br><size=100%>"
                    +"<size=100%>The famous solid-colour painting 'GREEN' by the artist known only as 'colOUR' was stolen last night from its display at the town museum. <br><br>"
                    +"This shocking theft has rocked the town. <br>"
                    +"It is believed that this was the work of a group of thieves who entered under the cover of night. Likely between 1 and 3am - when the museums alarms and security system were turned off. <br><br> "
                    +outfitText+" "+tookText+" "+sprayText+"<br><br>"
                    +"The museum curator stated 'This is a very sad day for the museum. To be targetted by such dishonourable people in this way is saddening. "
                    +"We display these pieces for the enjoyment of the public and to have these thieves cause such chaos is frightening. <br>"
                    +"<br>The town museum will be closed to the public until the police have concluded their scene investigation.";
            }
            break;
             case "Cyan":
            {
            canvasTextBox.text = "<b><size=150%>FAMED 'CYAN' PAINTING STOLEN </b><br><br><size=100%>"
                    +"<size=100%>The famous solid-colour painting 'CYAN' by the artist known only as 'colOUR' was stolen last night from its display at the town museum. <br><br>"
                    +"This covert theft has rocked the town. <br>"
                    +"It is believed that this was the work of a group of thieves who entered under the cover of night. Likely between 1 and 3am - when the museums alarms and security system were turned off. <br><br> "
                    +outfitText+" "+tookText+" "+sprayText+"<br><br>"
                    +"The museum curator stated 'Its extremely disappointing. To have a bunch of people slyly come in and take what we share with the public for themselves is very sad. "
                    +"<br><br>The town museum will be closed to the public until the police have concluded their scene investigation.";
            }
            break;
            case "Blue":
            {
            canvasTextBox.text = "<b><size=150%>FAMED 'BLUE' PAINTING STOLEN </b><br><br><size=100%>"
                    +"<size=100%>The famous solid-colour painting 'BLUE' by the artist known only as 'colOUR' was stolen last night from its display at the town museum. <br><br>"
                    +"This calculated theft has rocked the town. <br>"
                    +"It is believed that this was the work of a group of thieves who entered under the cover of night. Likely between 1 and 3am - when the museums alarms and security system were turned off. <br><br> "
                    +outfitText+" "+tookText+" "+sprayText+"<br><br>"
                    +"The museum curator stated 'This is extremely worrying. This is clearly quite an intelligent and stealthy group of robbers. "
                    +"The ingenuity used has us worried for repeat offences. We plan now to upgrade our security systems so that this can't happen again. <br>"
                    +"<br>The town museum will be closed to the public until the police have concluded their scene investigation.";
            }
            break;
            case "Magenta":
            {
            canvasTextBox.text = "<b><size=150%>FAMED 'MAGENTA' PAINTING STOLEN </b><br><br><size=100%>"
                    +"<size=100%>The famous solid-colour painting 'MAGENTA' by the artist known only as 'colOUR' was stolen last night from its display at the town museum. <br><br>"
                    +"This shrewd theft has rocked the town. <br>"
                    +"It is believed that this was the work of a group of thieves who entered under the cover of night. Likely between 1 and 3am - when the museums alarms and security system were turned off. <br><br> "
                    +outfitText+" "+tookText+" "+sprayText+"<br><br>"
                    +"The museum curator stated 'This is very disappointing and has galleries around the town worried about further thefts. "
                    +"It is a large loss for our museum and we will be looking to upgrade our security. <br>"
                    +"<br>The town museum will be closed to the public until the police have concluded their scene investigation.";
            }
            break;
            default:
            canvasTextBox.text = "NO COLOR END- game broken. :( )";
            break;
        }

    }

}
