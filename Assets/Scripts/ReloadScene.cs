using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ReloadScene : MonoBehaviour
{
     public GameObject failPanel;
   
    void OnTriggerEnter(Collider c)
    {
        if(c.CompareTag("Player")){
           // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
           failPanel.SetActive(true);
           //Invoke("ReturnToMenu", 2f);
           Invoke("Restart", 2f);
        }
    }

    // public void ReturnToMenu()
    // {
    //     SceneManager.LoadScene("Menu");
    // }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
