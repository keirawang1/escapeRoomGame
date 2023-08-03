using UnityEngine;
using UnityEngine.UI;

public class ChangeSprite : MonoBehaviour
{
    public Inventory inventory;
    public Sprite newSprite; // The new sprite image to assign to the selected GameObject

    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (inventory != null && inventory.currentSelectedSlot != null)
        {
            Image imageComponent = inventory.currentSelectedSlot.transform.GetChild(0).GetComponent<Image>();
            if (imageComponent != null)
            {
                imageComponent.sprite = newSprite;
            }
        }
    }
}
