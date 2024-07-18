using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinCollection : MonoBehaviour
{
    private int points;
    void Start()
    {
        points = 0;
    }
    public TextMeshProUGUI pointText;

     private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            points++;
            pointText.text = "Points: " + points.ToString();
        }

        if(other.tag == "Enemy")
        {
            points -= 2;
            pointText.text = "Point: " + points.ToString();
            if(points <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
