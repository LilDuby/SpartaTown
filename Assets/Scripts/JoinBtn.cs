using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class JoinBtn : MonoBehaviour
{
    public InputField inputName;
    public string nameStr = null;

    private void Awake()
    {
        nameStr = inputName.GetComponent<InputField>().text;
    }

    // Update is called once per frame
    void Update()
    {
        if (nameStr.Length >= 3)
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
