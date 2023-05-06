using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HealthSlider : MonoBehaviour
{
    public Slider healthBarSlider;
    Player player;
    public TextMeshProUGUI HPText;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Player>();

    }

    // Update is called once per frame
    void Update()
    {
        healthBarSlider.maxValue = player.maxHp;
        healthBarSlider.value = player.currentHp;
        //healthBarSlider.value = currentHp / maxHp;
        HPText.text = ((int)player.currentHp).ToString() + "/" + ((int)player.maxHp).ToString();
    }

}
