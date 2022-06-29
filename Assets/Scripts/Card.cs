using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CardEnum
{
    Character1,
    Character2,
    Character3,
    Character4,
    Character5,
    CharacterRedFive,
    Character6,
    Character7,
    Character8,
    Character9,
    Circles1,
    Circles2,
    Circles3,
    Circles4,
    Circles5,
    CirclesRedFive,
    Circles6,
    Circles7,
    Circles8,
    Circles9,
    Bamboos1,
    Bamboos2,
    Bamboos3,
    Bamboos4,
    Bamboos5,
    BamboosRedFive,
    Bamboos6,
    Bamboos7,
    Bamboos8,
    Bamboos9,
    E,
    S,
    W,
    N,
    White,
    Green,
    Red
}

public class Card
{
    public CardEnum Name { get; set; }
    public Sprite Image { get; set; }

    public Card(CardEnum name,int num, bool redFive = false)
    {
        this.Name = name;
        SetImage(num, redFive);
    }
    private void SetImage(int num, bool redFive = false) 
    {
        if (!redFive)
        {
            var newSprite = Resources.LoadAll<Sprite>("all");
            Image = newSprite[num];
        }
        else
        {
            var newSprite = Resources.LoadAll<Sprite>("redFive");
            Image = newSprite[num];
        }
    }
}
