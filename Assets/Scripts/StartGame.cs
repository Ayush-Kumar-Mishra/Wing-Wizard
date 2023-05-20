using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public GameObject playBtn;
    public GameObject logo;
    public AudioSource wingsAudio;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void Start_Game()
    {
        playBtn.gameObject.SetActive(false);
        logo.gameObject.SetActive(false);
        Time.timeScale = 1;
        wingsAudio.Play();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
