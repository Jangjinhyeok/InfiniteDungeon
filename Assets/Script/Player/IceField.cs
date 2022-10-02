using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceField : MonoBehaviour
{
    float interval;
    void Start()
    {
        interval = 3.0f;
    }

    void Update()
    {
        Destroy(gameObject, interval);
    }
}
