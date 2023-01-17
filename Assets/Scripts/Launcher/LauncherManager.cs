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

    public void noyourafool()
    {
        Debug.LogError("this game doesnt exist yet you fool!");
    }

    public AudioSource RemasteredLoop;
    public AudioSource LammyLoop;
    public AudioSource SequelLoop;

    public void PlayRL()
    {
        RemasteredLoop.Play();
        LammyLoop.Stop();
        SequelLoop.Stop();
    }
    public void PlayLL()
    {
        RemasteredLoop.Stop();
        LammyLoop.Play();
        SequelLoop.Stop();
    }
    public void PlaySL()
    {
        RemasteredLoop.Stop();
        LammyLoop.Stop();
        SequelLoop.Play();
    }
}
