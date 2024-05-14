using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GetPlayerName : MonoBehaviour
{
    public Text text;
    public string playerName;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    private void Start()
    {
        LoadPlayerName();
    }

    public void LoadPlayerName()
    {
        playerName = PlayerPrefs.GetString("nameData");
        text.text = playerName;
    }
}
