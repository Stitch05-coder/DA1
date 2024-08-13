using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class home : MonoBehaviour
{
    [SerializeField] int maxHeal;
    int currentHeal;
    public mau hp;
    string sce = "loss";
    private void Start()
    { currentHeal = maxHeal;
        hp.thanhhp(currentHeal, maxHeal);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    // {
    //     if(collision.CompareTag("quai"))
    //     {
    //         takedame(10);
    //     }
    // }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            takedam(10);
        }

    }

        public void takedame(int dame)
        {
            takedam(dame);
        }
        public void takedam(int dame)
        {
            currentHeal -= dame;

            if (currentHeal < 0)
            {
                SceneManager.LoadScene(sce);
            }
        }
    }
