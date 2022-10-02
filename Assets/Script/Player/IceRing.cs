using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceRing : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    void Update()
    {
        
    }
}
