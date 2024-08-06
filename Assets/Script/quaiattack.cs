using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quaiattack : MonoBehaviour
{
    public int dame;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Home")) 
        {
            InvokeRepeating("Damehome", 0, 1);
        }
    }
    void Damehome()
    {
        int dame;
    }
}
