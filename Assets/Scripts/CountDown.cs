using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDown : MonoBehaviour
{
    public int CountDownTime;

    [SerializeField] TextMeshProUGUI CountDownDisplay; // Changed TextMeshPro to TextMeshProUGUI
 
    [SerializeField] GameObject gear_Controles;
    [SerializeField] AudioSource CountDown_audio;

    private void Start()
    {
        StartCoroutine(CountDownToStart()); // Start the countdown coroutine
    }

    IEnumerator CountDownToStart()
    {
        while (CountDownTime > 0)
        {
            CountDown_audio.Play();
            CountDownDisplay.text = CountDownTime.ToString();
            yield return new WaitForSeconds(1f);
            CountDownTime--;
        }

        CountDownDisplay.text = "GO!";
        gear_Controles.SetActive(true);
        


        yield return new WaitForSeconds(1f);

        Destroy(gameObject); // Destroy the countdown script component
    }
}
