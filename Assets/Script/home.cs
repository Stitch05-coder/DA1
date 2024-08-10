using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class home : MonoBehaviour
{
    [SerializeField] int maxheal;
    int currentheal;
    public mau hp;
    private void Start()
    {
        currentheal = maxheal;
        hp.thanhhp(currentheal,maxheal);
    }
    public void takedame(int dame)
    {
        currentheal -= dame;

        if(currentheal <0)
        {
            
        }
    }
}
