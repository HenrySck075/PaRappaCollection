using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UJL_Initialization : MonoBehaviour
{
    [SerializeField] private AudioSource TitleLoop;

    public void Start()
    {
        TitleLoop.Play();
    }

    public void LoadGameState(string sceneName)
    {
        FindObjectOfType<LoadingManager>().LoadScene(sceneName);
    }
}
