using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BauControl : MonoBehaviour
{
    
    void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.tag == "Player")
        {
            Debug.Log("Tem a Pedra");
        } 
    }
}
