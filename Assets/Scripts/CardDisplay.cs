using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Text cardNameText;
    public Image cardImage;
    public Text valueText;
    
    private Card card;
    
    public void SetCard(Card cardData)
    {
        card = cardData;
        
        // Update visual elements based on the card data
        if (cardNameText != null)
            cardNameText.text = card.name;
            
        if (cardImage != null && card.sprite != null)
            cardImage.sprite = card.sprite;
            
        if (valueText != null)
            valueText.text = card.value.ToString();
            
        // Additional visual updates as needed
    }
} 