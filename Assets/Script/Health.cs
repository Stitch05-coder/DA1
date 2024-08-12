using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitPoints = 2;
    [SerializeField] private int currencyWorth = 50;
    private bool isDetroyed = false;

<<<<<<< Updated upstream
    private bool isDetroyed = false;
=======
    
>>>>>>> Stashed changes
    public void TakeDamage( int dmg)
    {
        hitPoints -= dmg;

        if (hitPoints <= 0 && !isDetroyed)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
<<<<<<< Updated upstream
=======
            LevelManager.main.IncreaseCurrency(currencyWorth);
>>>>>>> Stashed changes
            isDetroyed = true;

            Destroy(gameObject);
            
        }
    }
}
