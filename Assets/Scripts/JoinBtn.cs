using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinBtn : MonoBehaviour
{
    public InputField inputName;
    public string nameStr = null;

    public void StartGame()
    {
        nameStr = inputName.GetComponent<InputField>().text;
        if (nameStr.Length >= 2)
        {
            PlayerPrefs.SetString("nameData",nameStr);
            SceneManager.LoadScene("MainScene");
        }
    }
}
