using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager main;

    public Transform startPoint;
    public Transform[] path;

    public int currency;
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    public void Awake()
    {
        main = this; 
    }

<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes
    private void Start()
    {
        currency = 100;
    }

    public void IncreaseCurrency(int amount)
    {
        currency += amount;
    }

    public bool SpendCurrency(int amount)
    {
<<<<<<< Updated upstream
        if(amount <= currency)
        {
            //BUY ITEM
            currency -= amount;
            return true;

=======
        if (amount <= currency)
        {
            //BUY
            currency -= amount;
            return true;
>>>>>>> Stashed changes
        }
        else
        {
            return false;
        }
<<<<<<< Updated upstream
    }    
=======
    }
>>>>>>> Stashed changes
}
