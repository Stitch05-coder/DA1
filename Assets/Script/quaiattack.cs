using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaiattack : MonoBehaviour
{
    public int dame;
    home homes;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Home")) 
        {
            homes = collision.GetComponent<home>();
            InvokeRepeating("Damehome", 0, 0.1f);
        }
    }
    void Damehome()
    {
       homes.takedam(dame);
        Debug.Log("Home take dame " + dame);
    }
}
