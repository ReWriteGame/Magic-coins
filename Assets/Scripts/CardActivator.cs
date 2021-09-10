using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CardActivator : MonoBehaviour
{
    [SerializeField] private List<Card> cards;
    [SerializeField] private Vector2 timeSpawn;
    [SerializeField] private int sizeActivation = 0;

    public UnityEvent activationEndEvent;


    private void Start()
    {
        StartCoroutine(RandomActivation());
    }
    private IEnumerator RandomActivation()
    {
        for (int i = 0; i < sizeActivation; i++)
        {
            cards[Random.Range(0, cards.Capacity)].Activate();
            yield return new WaitForSeconds(Random.Range(timeSpawn.x, timeSpawn.y));
            DeactivatorAll();
        }

        activationEndEvent?.Invoke();
        yield break;
    }
    private void DeactivatorAll()
    {
        foreach (Card card in cards)
            card.Deactivate();
    }

}
