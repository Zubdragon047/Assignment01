using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public Player player;
    [SerializeField] private GameObject scoreTextMesh;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = FindObjectOfType<Player>();
        scoreTextMesh.GetComponent<TextMeshProUGUI>().text = "Score: " + player.playerScore;
    }
}
