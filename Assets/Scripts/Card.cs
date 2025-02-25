using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI valueText;
    public Image spriteImage;
    public TextMeshProUGUI nameText_copy;
    public TextMeshProUGUI valueText_copy;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = data.card_name;
        valueText.text = data.value;
        spriteImage.sprite = data.image;
        nameText_copy.text = data.card_name;
        valueText_copy.text = data.value;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}