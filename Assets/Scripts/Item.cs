using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] GameObject itemTile;
    Color color;
    int xSize, ySize;
    bool rotated;

    void Awake()
    {
        xSize = Random.Range(1, 5);
        ySize = Random.Range(1, 5);
        color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        rotated = false;
    }

    void Start()
    {
        for(int i = 0; i < xSize; i++)
        {
            for(int j = 0; j < ySize; j++)
            {
                GameObject item = Instantiate(itemTile, Vector2.right * i + Vector2.up * j, Quaternion.identity);
                item.GetComponent<SpriteRenderer>().color = color;
                item.transform.SetParent(transform, false);
            }
        }
    }

    public void Rotate()
    {
        rotated = !rotated;
        transform.Rotate(Vector3.forward * 180f);
    }

    public (int x, int y) GetPosition()
    {
        if (rotated)
        {
            return (ySize, xSize);
        }
        else
        {
            return (xSize, ySize);
        }
    }
}
