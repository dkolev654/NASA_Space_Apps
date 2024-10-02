using UnityEngine;
using UnityEngine.UI; // For handling UI elements

public class Entity : MonoBehaviour
{
    public GameObject infoPanel; // Assign your info panel here

    void Start()
    {
        // Initially hide the panel
        infoPanel.SetActive(false);
    }

    void Update()
    {
        // If the player presses Esc, hide the panel
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            infoPanel.SetActive(false);
        }
    }

    // When the player clicks on the entity
    void OnMouseDown()
    {
        // Show the information panel
        infoPanel.SetActive(true);
    }
}
