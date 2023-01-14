using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UJL_Initialization : MonoBehaviour
{
    public Image FadeImage;
    public GameObject SCEA;
    public GameObject Player;

    public void Start()
    {
        SceneManager.LoadScene("Fire");
        /*
        SCEA.SetActive(true);
        Player.SetActive(false);
        FadeImage.gameObject.SetActive(false);
        //Invoke("StartVideo", 1);
        */
    }

    private void StartVideo()
    {
        Debug.LogWarning("video should start here, but ive temporarily disabled it");
        SCEA.SetActive(false);
        //GetComponent<UJL_VideoPlayer>().PlayVideo();
    }
}
