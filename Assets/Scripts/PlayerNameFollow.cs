using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameFollow : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = Camera.main.WorldToScreenPoint(player.transform.position + Vector3.up); 
    }
}
