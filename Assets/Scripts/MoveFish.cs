using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFish : MonoBehaviour
{
    public float speed = 120f;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position -= new Vector3(speed * Time.deltaTime, 0f, 0f);
        }
    }

}
