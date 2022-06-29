using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class Rule : MonoBehaviour
{
    public GameObject myHandObject;
    public GameObject turnObject;
        
    // 최대 판수
    private const int MaxTurn = 70;
    // 현재 판수
    private int _currentTurn;

    private List<Card> _myHand;
    private Card _drawHand;
    private char _myTurn;
    
    private void Awake()
    {
        _currentTurn = MaxTurn;
        _myHand = new List<Card>();
        _drawHand = default;
        _myTurn = default;
    }

    #region Hand
    public void AddMyHand(Card card, Sprite image)
    {
        if (CanAddMyHand())
        {
            myHandObject.transform.GetChild(_myHand.Count).GetComponent<Image>().sprite = image;          
            _myHand.Add(card);
        }
        else
        {
            if(_drawHand == null) 
            {
                myHandObject.transform.GetChild(_myHand.Count).GetComponent<Image>().sprite = image;
                _drawHand = card;
            }
            SortMyHand();
        }
    }

    public void RemoveMyHand(int pos)
    {
        var newSprite = Resources.LoadAll<Sprite>("all");
        myHandObject.transform.GetChild(pos).GetComponent<Image>().sprite = newSprite[34];
        if (pos == 13)
        {      
            _drawHand = null;
            return;
        }
        _myHand.Remove(_myHand[pos]);
        _myHand.Add(_drawHand);
        _drawHand = null;
        myHandObject.transform.GetChild(13).GetComponent<Image>().sprite = newSprite[34];
        SortMyHand();
    }
    
    private bool CanAddMyHand()
    {
        return (_myHand.Count < 13) ? true : false;
    }
    private void SortMyHand()
    {
        _myHand = _myHand.OrderBy(x => x.Name).ToList();
        for (var i = 0; i < _myHand.Count; i++)
        {
            myHandObject.transform.GetChild(i).GetComponent<Image>().sprite = _myHand[i].Image;
        }
    }
    #endregion Hand

    #region Turn
    public void ChangeTurn(char direction)
    {
        _currentTurn--;
        if (_myTurn == '\0')
        {
            _myTurn = direction;
            ResetColor();
            SetMyTurnColor();
        }
        else
        {
            ResetColor();
            SetTurnColor(direction);
        }
    }
    private void SetMyTurnColor()
    {
        switch (_myTurn)
        {
            case'E':
                turnObject.transform.GetChild(0).GetComponent<Image>().color = Color.cyan;
                break;
            case'S':
                turnObject.transform.GetChild(1).GetComponent<Image>().color = Color.cyan;
                break;
            case'W':
                turnObject.transform.GetChild(2).GetComponent<Image>().color = Color.cyan;
                break;
            case'N':
                turnObject.transform.GetChild(3).GetComponent<Image>().color = Color.cyan;
                break;
        }
    }
    private void SetTurnColor(char direction)
    {
        switch (direction)
        {
            case'E':
                if(turnObject.transform.GetChild(0).GetComponent<Image>().color == Color.cyan)
                    break;
                turnObject.transform.GetChild(0).GetComponent<Image>().color = Color.red;
                break;
            case'S':
                if(turnObject.transform.GetChild(1).GetComponent<Image>().color == Color.cyan)
                    break;
                turnObject.transform.GetChild(1).GetComponent<Image>().color = Color.red;
                break;
            case'W':
                if(turnObject.transform.GetChild(2).GetComponent<Image>().color == Color.cyan)
                    break;
                turnObject.transform.GetChild(2).GetComponent<Image>().color = Color.red;
                break;
            case'N':
                if(turnObject.transform.GetChild(3).GetComponent<Image>().color == Color.cyan)
                    break;
                turnObject.transform.GetChild(3).GetComponent<Image>().color = Color.red;
                break;
        }
    }
    private void ResetColor()
    {
        for (var i = 0; i < turnObject.transform.childCount; i++)
        {
            if(_myTurn.ToString() == turnObject.transform.GetChild(i).name)
                continue;
            turnObject.transform.GetChild(i).GetComponent<Image>().color = Color.white;
        }
    }
    #endregion Turn
    
    
}
