using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    void Start()
    {
        float x = UnityEngine.Random.Range(-25f, 25f);
        float y = UnityEngine.Random.Range(-13f, 13f);
        this.transform.position = new Vector3(Mathf.FloorToInt(x), Mathf.FloorToInt(y), 0.0f);
    }
}
