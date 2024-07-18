using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndLevel : MonoBehaviour
{
    public GameObject winPanel;

    public void OnTriggerEnter()
    {
        winPanel.SetActive(true);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene("Menu");
    }
    
}
