using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> hand = new List<Card>();
    public List<GameObject> instantiatedCards = new List<GameObject>();
    public Vector3 handPosition = new Vector3(-5f, 0f, 0f); // Default position for the hand
} 