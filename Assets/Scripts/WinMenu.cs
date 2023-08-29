using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class WinMenu : MonoBehaviour
{
    public GameObject WinPanel;

    //public AudioSource AudioSource;

    private void Awake()
    { 
        WaitAndHidePanel();
    }
    public void Pause()
    {
        WinPanel.SetActive(true);
        StartCoroutine(WaitAndHidePanel());
    }

    private IEnumerator WaitAndHidePanel()
    {
        yield return new WaitForSeconds(3);
        Time.timeScale = 0;
    }
    public void NextLevel(int level)
    {
        string levelName = "level-" + level;
        SceneManager.LoadScene("Level-" + level.ToString());
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}

