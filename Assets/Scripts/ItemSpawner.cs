using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] GameObject item;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(item, transform.position, Quaternion.identity);
    }
}
