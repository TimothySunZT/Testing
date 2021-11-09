using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;

    public Text costText;
    public Text serialText;
    public Text rairtyText;
    public Text typeText;
    public Text descriptionText;
    public Text nameText;

    public Image cardImage;

    private void Start()
    {
        costText.text = card.cardCost.ToString();
        serialText.text = card.cardSerial.ToString();

        rairtyText.text = card.cardRairty;
        typeText.text = card.cardType;
        descriptionText.text = card.cardDecrisption;
        nameText.text = card.cardName;

        cardImage.sprite = card.cardSprite;
    }

}

