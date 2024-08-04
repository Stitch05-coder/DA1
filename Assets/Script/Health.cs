using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [Header("Attributes")]
    [SerializeField] private int hitPoints = 2;

    private bool isDetroyed = false;
    public void TakeDamage( int dmg)
    {
        hitPoints -= dmg;

        if (hitPoints <= 0 && !isDetroyed)
        {
            EnemySpawner.onEnemyDestroy.Invoke();
            isDetroyed = true;

            Destroy(gameObject);
        }
    }
}
