using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KluczLosuLosu : MonoBehaviour
{

    private Vector3 startPos;

    public float speed = 1;
    public float xScale = 1;
    public float yScale = 1;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {

        if (KluczPickUp.trafienie == 0)
        {
            transform.position = startPos + (Vector3.right * Mathf.Sin(Time.timeSinceLevelLoad / 2 * speed) * xScale - Vector3.up * Mathf.Sin(Time.timeSinceLevelLoad * speed) * yScale);
        }
        else if (KluczPickUp.trafienie == 1)
        {


        }






    }
}
