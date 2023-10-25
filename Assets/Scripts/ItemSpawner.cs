using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] Item item;
    bool spawnItem;

    // Start is called before the first frame update
    void Start()
    {
        InstantiateItem();
    }

    public void InstantiateItem()
    {
        if (!spawnItem)
        {
            Instantiate(item, transform).Initialize(this);
            spawnItem = true;
        }
    }

    public void MoveItem()
    {
        spawnItem = false;
    }
}
