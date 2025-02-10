using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    public string card_name;
    public string value;
    public Sprite image; // Changed from image to sprite to match Card_data

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI valueText;
    public Image spriteImage; // Corrected type to Image

    // Start is called before the first frame update
    void Start()
    {
        card_name = data.card_name;
        value = data.value;
        image = data.image;

        nameText.text = card_name;
        valueText.text = value;
        spriteImage.sprite = image; // Changed from image to sprite
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}