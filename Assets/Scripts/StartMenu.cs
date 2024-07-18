using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    // void Start()
    // {
    //     Time.timeScale = 1.0f;
    // }
    public static void PlayGame()
    {
        SceneManager.LoadScene("Game");
    }
}
