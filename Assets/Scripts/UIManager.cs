using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Rule ruleObject;

    public void InputTableButton(Card card, Sprite image)
    {
        ruleObject.AddMyHand(card, image);
    }
    
    public void InputMyHandButton(int pos)
    {
        ruleObject.RemoveMyHand(pos);
    }
    
    public void InputTurnButton(char direction)
    {
        ruleObject.ChangeTurn(direction);
    }
}
