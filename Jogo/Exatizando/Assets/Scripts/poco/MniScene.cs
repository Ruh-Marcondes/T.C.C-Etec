using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MniScene : MonoBehaviour
{
   private int vez = 1;
    void Start()
    {
        
    }

      void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag =="Player" && vez == 1){
            vez++;
            Debug.Log("Onde Eu Estou?");
        }
    }
}
