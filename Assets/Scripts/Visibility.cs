using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visibility : MonoBehaviour
{
    public SpriteRenderer bgSpriteRenderer;
    public Sprite specificBackgroundImage;

    void OnEnable()
    {
        // Initially update the visibility based on the current background.
        UpdateGameObjectVisibility();
    }

    void Update()
    {
        // Update the visibility whenever the background changes.
        UpdateGameObjectVisibility();
    }

    private void UpdateGameObjectVisibility()
    {
        if (bgSpriteRenderer.sprite == specificBackgroundImage)
        {
            // Show the game object if the background matches the specific image.
            gameObject.SetActive(true);
        }
        else
        {
            // Hide the game object if the background does not match the specific image.
            gameObject.SetActive(false);
        }
    }
}
