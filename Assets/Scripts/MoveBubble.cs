using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBubble : MonoBehaviour
{
    public float speed;
    
    void Start()
    {
        speed = speed / 60f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f, speed * Time.deltaTime, 0f);
    }
}
