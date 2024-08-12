using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager main;

    [Header("References")]
    [SerializeField] private GameObject[] towerPrefabs;

    private int selectedTower = 0;

    private void Awake()
    {
        main = this;
    }

<<<<<<< Updated upstream
    public GameObject GetSelectedTower()
=======
    public GameObject GetSelectedTowers()
>>>>>>> Stashed changes
    {
        return towerPrefabs[selectedTower];
    }
}
