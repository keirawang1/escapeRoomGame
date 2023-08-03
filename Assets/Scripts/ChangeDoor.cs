using UnityEngine;
using UnityEngine.UI;

public class ChangeDoor : MonoBehaviour
{
    public Inventory inventory;
    public Sprite specificSprite; // The specific sprite the selected GameObject must have to change the button sprite
    public Sprite newButtonSprite; // The new sprite for the button when the condition is met

    private Button button;
    private GameObject buttonSprite; // Reference to the GameObject representing the button sprite
    private SpriteRenderer buttonSpriteRenderer; // Reference to the SpriteRenderer component of the button sprite

    private void Start()
    {
        button = GetComponent<Button>();
        buttonSprite = transform.Find("ButtonSprite").gameObject;
        buttonSpriteRenderer = buttonSprite.GetComponent<SpriteRenderer>();
        
        // Assign the default sprite to the button sprite when the script starts
        buttonSpriteRenderer.sprite = specificSprite;

        button.onClick.AddListener(OnClick);
    }

    private void OnClick()
    {
        if (inventory != null && inventory.currentSelectedSlot != null)
        {
            SpriteRenderer selectedSpriteRenderer = inventory.currentSelectedSlot.GetComponent<SpriteRenderer>();
            if (selectedSpriteRenderer != null)
            {
                Debug.Log("Selected Sprite: " + selectedSpriteRenderer.sprite.name);
                Debug.Log("Specific Sprite: " + specificSprite.name);

                if (selectedSpriteRenderer.sprite == specificSprite)
                {
                    buttonSpriteRenderer.sprite = newButtonSprite;
                    Debug.Log("Button Sprite changed to New Button Sprite!");
                }
                else
                {
                    buttonSpriteRenderer.sprite = specificSprite; // Revert to the specific sprite if the condition is not met
                    Debug.Log("Selected GameObject doesn't have the specific sprite. Button Sprite set to Specific Sprite.");
                }
            }
            else
            {
                buttonSpriteRenderer.sprite = specificSprite; // Revert to the specific sprite if no SpriteRenderer component is found on the selected GameObject
                Debug.Log("No SpriteRenderer component found on the selected GameObject. Button Sprite set to Specific Sprite.");
            }
        }
        else
        {
            buttonSpriteRenderer.sprite = specificSprite; // Revert to the specific sprite if no GameObject is selected in the Inventory
            Debug.Log("No selected GameObject in the Inventory. Button Sprite set to Specific Sprite.");
        }
    }
}
