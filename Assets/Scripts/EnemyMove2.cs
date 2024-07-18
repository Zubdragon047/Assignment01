using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove2 : MonoBehaviour
{
    public float amp;
    public float freq;
    Vector3 initPos;
    
    void Start()
    {
       initPos = transform.position;
        amp = 1.4f;
        freq = 1.3f;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(initPos.x, Mathf.Cos(Time.time * freq) * amp +1.5f*initPos.y, 0);
    }
}
