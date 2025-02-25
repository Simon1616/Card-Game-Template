using UnityEngine;

public class Dealer : MonoBehaviour
{
    public GameObject cardPrefab; // Reference to the card prefab

    public void InstantiatePlayerHand(Player player)
    {
        // Check if player has a hand
        if (player == null || player.hand == null || player.hand.Count == 0)
        {
            Debug.LogWarning("Player or hand is empty, nothing to instantiate");
            return;
        }
        
        // Clear any existing card objects
        ClearPlayerHandObjects(player);
        
        // Calculate layout positioning
        float offset = 2.0f; // Spacing between cards
        float startX = -((player.hand.Count - 1) * offset) / 2;
        Vector3 screenCenter = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width / 2, Screen.height / 2, Camera.main.nearClipPlane));
        screenCenter.z = 0; // Ensure z is set to 0
        
        // Instantiate each card in the player's hand
        for (int i = 0; i < player.hand.Count; i++)
        {
            // Get the card from the player's hand
            Card cardTemplate = player.hand[i];
            
            // Calculate position for this card
            Vector3 cardPosition = screenCenter + new Vector3(startX + i * offset, -3.5f, 0);
            
            // Instantiate the card prefab
            GameObject cardObject = Instantiate(cardPrefab, cardPosition, Quaternion.identity);
            
            // Set the card data
            Card cardComponent = cardObject.GetComponent<Card>();
            if (cardComponent != null)
            {
                cardComponent.data = cardTemplate.data;
            }
            
            // Add the card object to the player's instantiated cards list
            player.instantiatedCards.Add(cardObject);
            
            // Debug log
            Debug.Log("Card instantiated at position: " + cardPosition);
        }
    }

    private void ClearPlayerHandObjects(Player player)
    {
        // Destroy any existing card objects
        if (player.instantiatedCards != null)
        {
            foreach (GameObject cardObject in player.instantiatedCards)
            {
                if (cardObject != null)
                {
                    Destroy(cardObject);
                }
            }
            player.instantiatedCards.Clear();
        }
    }
} 