using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plot : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Color hoverColor;

<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
    private GameObject tower;
    private Color startColor;


    private void Start()
    {
        startColor = sr.color;
    }
    private void OnMouseEnter()
    {
        sr.color = hoverColor;
    }

    private void OnMouseExit()
    {
        sr.color = startColor;
    }

    private void OnMouseDown()
    {
<<<<<<< Updated upstream
        if(tower != null) return;

        GameObject towerToBuild = BuildManager.main.GetSelectedTower();
        tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);
    }

=======
        if (tower != null) return;

        GameObject towerToBuild = BuildManager.main.GetSelectedTowers();

        tower = Instantiate(towerToBuild, transform.position, Quaternion.identity);
    }
>>>>>>> Stashed changes
}
