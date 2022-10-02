using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPSlider : MonoBehaviour
{
    public Slider expBarSlider;
    Player player;

    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        expBarSlider.maxValue = player.maxexp;
        expBarSlider.value = player.exp;
    }
}
