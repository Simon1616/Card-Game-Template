using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    public List<Card> player_deck = new List<Card>();
    public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();
    
    // Reference to dealer component
    public Dealer dealer;
    // Reference to player component
    public Player player;

    public float turn;

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
        
        // Find or add dealer and player if not set
        if (dealer == null) dealer = FindObjectOfType<Dealer>();
        if (player == null) player = FindObjectOfType<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        turn = 1;
        Deal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Deal()
    {
        turn++;
        Shuffle();
        while (player_hand.Count < turn)
        {
            player_hand.Add(deck[0]);
            deck.RemoveAt(0);
        }
        while (ai_hand.Count < turn)
        {
            ai_hand.Add(deck[0]);
            deck.RemoveAt(0);
        }
        
        // Update player's hand
        if (player != null)
        {
            player.hand = player_hand;
        }
        
        InstantiatePlayerHand();
    }

    void Shuffle()
    {
        for (int i = 0; i < deck.Count; i++)
        {
            Card temp = deck[i];
            int randomIndex = Random.Range(i, deck.Count);
            deck[i] = deck[randomIndex];
            deck[randomIndex] = temp;
        }
    }

    void InstantiatePlayerHand()
    {
        // Use the dealer to instantiate player's hand
        if (dealer != null && player != null)
        {
            dealer.InstantiatePlayerHand(player);
        }
        else
        {
            Debug.LogError("Dealer or Player component is missing");
        }
    }

    void AI_Turn()
    {

    }
}
