using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parking_controller : MonoBehaviour
{
    private HashSet<GameObject> enteredTriggers = new HashSet<GameObject>();

    private bool allTriggersEntered = false;
    public Material parkArea;

    [SerializeField] private Color greenColor = Color.green; // Assign the green in the Inspector

    [SerializeField] GameObject WinPanel;
  
    // This function is called when the player enters any trigger collider attached to this object
    private void OnTriggerEnter(Collider other)
    {
        enteredTriggers.Add(other.gameObject);

        // Check if the game object has entered all four triggers
        if (enteredTriggers.Count == 4 && !allTriggersEntered)
        {
            allTriggersEntered = true;

            ChangeTriggersColor(greenColor);
            GameWinUI();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        // Remove the exited collider from the HashSet
        enteredTriggers.Remove(other.gameObject);

        // If the game object exits one of the triggers, reset the allTriggersEntered flag
        if (allTriggersEntered && enteredTriggers.Count < 4)
        {
            allTriggersEntered = false;

            ChangeTriggersColor(Color.red);
        }
    }

    private void ChangeTriggersColor(Color newColor)
    {
        parkArea.color = newColor;      
    }

    private void GameWinUI()
    {
        WinPanel.SetActive(true);
    }
}
