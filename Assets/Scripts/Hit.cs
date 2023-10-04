using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    [SerializeField] GameObject ExitMenu;
 
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the vehicles GameObject
        if (collision.gameObject.CompareTag("Vehicles") || collision.gameObject.CompareTag("Pedestrians"))
        {            // Destroy the player GameObject
            ExitMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            ExitMenu.SetActive(false);
        }
    }
}
