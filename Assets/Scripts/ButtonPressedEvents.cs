using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressedEvents : MonoBehaviour
{
    public UIManager uiManagerObject;

    #region Characters
    public void Character1()
    {
        var card = new Card(CardEnum.Character1,0);
        var newSprite = Resources.LoadAll<Sprite>("all");
        
        uiManagerObject.InputTableButton(card, newSprite[0]);
    }
    public void Character2()
    {
        var card = new Card(CardEnum.Character2,1);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[1]);
    }
    public void Character3()
    {
        var card = new Card(CardEnum.Character3,2);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[2]);
    }
    public void Character4()
    {
        var card = new Card(CardEnum.Character4,3);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[3]);
    }
    public void Character5()
    {
        var card = new Card(CardEnum.Character5,4);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[4]);
    }
    public void Character6()
    {
        var card = new Card(CardEnum.Character6,5);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[5]);
    }
    public void Character7()
    {
        var card = new Card(CardEnum.Character7,6);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[6]);
    }
    public void Character8()
    {
        var card = new Card(CardEnum.Character8,7);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[7]);
    }
    public void Character9()
    {
        var card = new Card(CardEnum.Character9,8);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[8]);
    }
    public void CharacterRedFive()
    {
        var card = new Card(CardEnum.CharacterRedFive,0, true);
        var newSprite = Resources.LoadAll<Sprite>("redFive");

        uiManagerObject.InputTableButton(card, newSprite[0]);
    }
    #endregion Characters

    #region Circles
    public void Circles1()
    {
        var card = new Card(CardEnum.Circles1,9);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[9]);
    }
    public void Circles2()
    {
        var card = new Card(CardEnum.Circles2,10);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[10]);
    }
    public void Circles3()
    {
        var card = new Card(CardEnum.Circles3,11);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[11]);
    }
    public void Circles4()
    {
        var card = new Card(CardEnum.Circles4,12);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[12]);
    }
    public void Circles5()
    {
        var card = new Card(CardEnum.Circles5,13);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[13]);
    }
    public void Circles6()
    {
        var card = new Card(CardEnum.Circles6,14);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[14]);
    }
    public void Circles7()
    {
        var card = new Card(CardEnum.Circles7,15);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[15]);
    }
    public void Circles8()
    {
        var card = new Card(CardEnum.Circles8,16);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[16]);
    }
    public void Circles9()
    {
        var card = new Card(CardEnum.Circles9,17);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[17]);
    }
    public void CirclesRedFive()
    {
        var card = new Card(CardEnum.CirclesRedFive,1, true);
        var newSprite = Resources.LoadAll<Sprite>("redFive");

        uiManagerObject.InputTableButton(card, newSprite[1]);
    }
    #endregion Circles

    #region Bamboos
    public void Bamboos1()
    {
        var card = new Card(CardEnum.Bamboos1,18);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[18]);
    }
    public void Bamboos2()
    {
        var card = new Card(CardEnum.Bamboos2,19);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[19]);
    }
    public void Bamboos3()
    {
        var card = new Card(CardEnum.Bamboos3,20);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[20]);
    }
    public void Bamboos4()
    {
        var card = new Card(CardEnum.Bamboos4,21);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[21]);
    }
    public void Bamboos5()
    {
        var card = new Card(CardEnum.Bamboos5,22);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[22]);
    }
    public void Bamboos6()
    {
        var card = new Card(CardEnum.Bamboos6,23);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[23]);
    }
    public void Bamboos7()
    {
        var card = new Card(CardEnum.Bamboos7,24);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[24]);
    }
    public void Bamboos8()
    {
        var card = new Card(CardEnum.Bamboos8,25);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[25]);
    }
    public void Bamboos9()
    {
        var card = new Card(CardEnum.Bamboos9,26);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[26]);
    }
    public void BamboosRedFive()
    {
        var card = new Card(CardEnum.BamboosRedFive,2, true);
        var newSprite = Resources.LoadAll<Sprite>("redFive");

        uiManagerObject.InputTableButton(card, newSprite[2]);
    }
    #endregion Bamboos

    #region HonorsAndDragons
    public void E()
    {
        var card = new Card(CardEnum.E,27);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[27]);
    }
    public void S()
    {
        var card = new Card(CardEnum.S,28);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[28]);
    }
    public void W()
    {
        var card = new Card(CardEnum.W,29);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[29]);
    }
    public void N()
    {
        var card = new Card(CardEnum.N,30);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[30]);
    }
    public void White()
    {
        var card = new Card(CardEnum.White,31);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[31]);
    }
    public void Green()
    {
        var card = new Card(CardEnum.Green,32);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[32]);
    }
    public void Red()
    {
        var card = new Card(CardEnum.Red,33);
        var newSprite = Resources.LoadAll<Sprite>("all");

        uiManagerObject.InputTableButton(card, newSprite[33]);
    }
    #endregion HonorsAndDragons
    
    #region MyHands
    public void MyHand1()
    {
        uiManagerObject.InputMyHandButton(0);
    }
    public void MyHand2()
    {
        uiManagerObject.InputMyHandButton(1);
    }
    public void MyHand3()
    {
        uiManagerObject.InputMyHandButton(2);
    }
    public void MyHand4()
    {
        uiManagerObject.InputMyHandButton(3);

    }
    public void MyHand5()
    {
        uiManagerObject.InputMyHandButton(4);
    }
    public void MyHand6()
    {
        uiManagerObject.InputMyHandButton(5);
    }
    public void MyHand7()
    {
        uiManagerObject.InputMyHandButton(6);
    }
    public void MyHand8()
    {
        uiManagerObject.InputMyHandButton(7);
    }
    public void MyHand9()
    {
        uiManagerObject.InputMyHandButton(8);
    }
    public void MyHand10()
    {
        uiManagerObject.InputMyHandButton(9);
    }
    public void MyHand11()
    {
        uiManagerObject.InputMyHandButton(10);
    }
    public void MyHand12()
    {
        uiManagerObject.InputMyHandButton(11);
    }
    public void MyHand13()
    {
        uiManagerObject.InputMyHandButton(12);
    }
    public void MyHand14()
    {
        uiManagerObject.InputMyHandButton(13);
    }
    #endregion MyHands

    #region Turn
    public void ETurn()
    {
        uiManagerObject.InputTurnButton('E');
    }
    public void STurn()
    {
        uiManagerObject.InputTurnButton('S');
    }
    public void WTurn()
    {
        uiManagerObject.InputTurnButton('W');
    }
    public void NTurn()
    {
        uiManagerObject.InputTurnButton('N');
    }
    #endregion Turn
    
    #region Doras
    public void Dora1()
    {
        
    }
    public void Dora2()
    {
        
    }
    public void Dora3()
    {
        
    }
    public void Dora4()
    {
        
    }
    public void Dora5()
    {
        
    }
    #endregion Doras
    
    #region Calls
    public void Calls1()
    {
        
    }
    public void Calls2()
    {
        
    }
    public void Calls3()
    {
        
    }
    public void Calls4()
    {
        
    }
    public void Calls5()
    {
        
    }
    public void Calls6()
    {
        
    }
    public void Calls7()
    {
        
    }
    public void Calls8()
    {
        
    }
    public void Calls9()
    {
        
    }
    #endregion Calls
}
