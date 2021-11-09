using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This is the basic class for every cards.
/// </summary>
[CreateAssetMenu(fileName = "New Card", menuName = "Card/Software")]
public class Card : ScriptableObject
{
    public string cardName;
    public string cardDecrisption;
    public string cardType;
    public string cardRairty;

    public int cardCost;
    public int cardSerial;
    

   
    public Sprite cardSprite;
}
