using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    [SerializeField] private GameObject active;
    [SerializeField] private GameObject notActive;
    [SerializeField] private int id = 0;
    [SerializeField] private bool isActive = false;

    public bool IsActive { get => isActive; private set => isActive = value; }
    public int ID { get => id; private set => id = value; }

    private void Start()
    {
        Deactivate();
    }

    public void Activate()
    {
        active.SetActive(true);
        notActive.SetActive(false);
        isActive = true;
    }

    public void Deactivate()
    {
        active.SetActive(false);
        notActive.SetActive(true);
        isActive = false;

    }

}


