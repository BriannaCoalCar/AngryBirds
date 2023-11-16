using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadButton : MonoBehaviour
{
    public AudioSource audio;
    public void ReloadGame()
    {
        audio.Play();
        Invoke(nameof(Reload), 0.5f);
    }

    public void Reload() 
    {
        SceneManager.LoadScene(1);
    }
}