using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinTracker : MonoBehaviour
{
     public int coins;
    void Start()
    {
        coins = 0;
    }
    public TextMeshProUGUI coinText;

     private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            coins++;
            coinText.text = "Coins: " + coins.ToString();
        }
    }
     // if(other.tag == "Enemy")
        // {
        //     points -= 2;
        //     pointText.text = "Point: " + points.ToString();
        //     if(points <= 0)
        //     {
        //         SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //     }
        // }
}
