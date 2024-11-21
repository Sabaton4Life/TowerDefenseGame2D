using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform[] path;

    public Transform startPoint;

    public int currency;
    
    private void Awake()
    {
        main = this;
    }

    private void Start()
    {
        currency = 10;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpentCurrency(int amount)
    {
        if(amount <= currency)
        {
            currency -= amount;
            return true;
        }else
        {
            Debug.Log("You have no money");
            return false;
        }
    }
}
