using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventoryTile : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] int x, y;
    [SerializeField] Image image;

    public void Initialize(int _x, int _y)
    {
        x = _x;
        y = _y;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        image.color = Color.grey;
        Debug.Log($"{x}, {y} Enter");
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        image.color = Color.white;
        Debug.Log($"{x}, {y} Exit");
    }
}
