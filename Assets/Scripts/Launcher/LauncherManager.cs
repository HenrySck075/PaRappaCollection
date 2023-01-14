using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherManager : MonoBehaviour
{
    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject playMenu;
    [SerializeField] private GameObject settingsMenu;

    private void Awake()
    {
        startMenu.SetActive(true);
        playMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }

    public void BackButton()
    {
        startMenu.SetActive(true);
        playMenu.SetActive(false);
        settingsMenu.SetActive(false);
    }

    public void QuitButton()
    {
        Debug.Log("GAME QUIT");
        Application.Quit();
    }

    public void ShowPlayMenu()
    {
        startMenu.SetActive(false);
        playMenu.SetActive(true);
    }

    public void ShowSettingsMenu()
    {
        startMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
}
