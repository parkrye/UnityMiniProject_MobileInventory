using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] GameObject itemTile;
    [SerializeField] int xSize, ySize, xPos, yPos;
    Color color;
    RectTransform rect;

    void Awake()
    {
        xSize = Random.Range(1, 5);
        ySize = Random.Range(1, 5);
        xPos = 0;
        yPos = 0;
        color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        rect = GetComponent<RectTransform>();
    }

    void Start()
    {
        for(int i = 0; i < xSize; i++)
        {
            for(int j = 0; j < ySize; j++)
            {
                GameObject item = Instantiate(itemTile, transform);
                item.GetComponent<Image>().color = color;
                item.GetComponent<RectTransform>().anchoredPosition = new Vector2(i * 142, j * 142);
            }
        }
    }

    public (int x, int y) GetPosition()
    {
        return (yPos, yPos);
    }

    public (int x, int y) GetSize()
    {
        return (xSize, ySize);
    }

    public void SetPosition(int _x, int _y)
    {
        xPos = _x;
        yPos = _y;
    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {

    }

    public void OnDrag(PointerEventData eventData)
    {
        rect.position = eventData.position;
    }
}
