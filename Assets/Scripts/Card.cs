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
    public Sprite image;
    public string card_name_copy;
    public string value_copy;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI valueText;
    public Image spriteImage;
    public TextMeshProUGUI nameText_copy;
    public TextMeshProUGUI valueText_copy;

    // Start is called before the first frame update
    void Start()
    {
        card_name = data.card_name;
        value = data.value;
        image = data.image;
        card_name_copy = data.card_name;
        value_copy = data.value;

        nameText.text = card_name;
        valueText.text = value;
        spriteImage.sprite = image;
        nameText_copy.text = card_name_copy;
        valueText_copy.text = value_copy;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}