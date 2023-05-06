using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject winFadeIn;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {            
            winFadeIn.SetActive(true);
        }
    }
}
