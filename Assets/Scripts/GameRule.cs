using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameRule : MonoBehaviour
{
    [SerializeField] private List<Card> cards;

    public UnityEvent cardsMatchedEvent;
    public UnityEvent cardsNotMatchedEvent;

    public void CardforComparison(int value)
    {
    
        for (int i = 0; i < cards.Capacity; i++)
        {
            if (cards[i].IsActive)
            {
                if (cards[i].ID == value)
                {
                    //cards.Remove(cards[i]);
                    cardsMatchedEvent?.Invoke();
                    break;
                }

                if (i == cards.Capacity - 1)
                    cardsNotMatchedEvent?.Invoke();
            }
        }
    }


}
