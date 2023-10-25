using Unity.VisualScripting;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    static Cursor instance;
    public static Cursor Instance { get { return instance; } }

    void Awake()
    {
        if (instance)
        {
            Destroy(this);
            return;
        }

        instance = this;
    }

    void OnDestroy()
    {
        if(instance == this)
            instance = null;
    }

    Item item;
    public Item TakeItem(Item _item)
    {
        if (item == null)
            item = _item;

        return item;
    }
}
