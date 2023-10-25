using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] InventoryTile inventoryTile;

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
            Instantiate(inventoryTile, transform).Initialize(i % 10, i / 10);
        }
    }
}
