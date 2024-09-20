using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager _instance; // 유일성 보장
    static void Init()
    {
        if (_instance == null)
        {
            GameObject go = GameObject.Find("GameManager");
            if (go == null)
            {
                go = new GameObject { name = "@GameManager" };
                go.AddComponent<GameManager>();
            }
            DontDestroyOnLoad(go);
            _instance = go.GetComponent<GameManager>();
        }
    }
}
