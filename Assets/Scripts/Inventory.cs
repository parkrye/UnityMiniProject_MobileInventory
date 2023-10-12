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
        for(int i = -(inventorySize >> 1); i <= inventorySize >> 1; i++)
        {
            for (int j = -(inventorySize >> 1); j <= inventorySize >> 1; j++)
            {
                Instantiate(inventoryTile, Vector2.right * i + Vector2.up * (j + transform.position.y), Quaternion.identity, transform);
            }
        }
    }
}
