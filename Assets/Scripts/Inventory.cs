using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] GameObject inventoryTile;

    int inventorySize;
    bool[,] inventory;

    void Awake()
    {
        inventorySize = 9;
        inventory = new bool[inventorySize, inventorySize];
    }

    void Start()
    {
        for(int i = 0; i < 100; i++)
        {
            Instantiate(inventoryTile, transform);
        }
    }
}
