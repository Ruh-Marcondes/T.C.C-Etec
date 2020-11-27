using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class R : MonoBehaviour
{
    public GameObject Object;

    private void Start() {
      Object.SetActive(false);
    }

     private void OnTriggerEnter2D(Collider2D other) {
       if(other.gameObject.tag == "Player"){
        Object.SetActive(true);
        MovimentePlayer._canMove_Placa = false;
   }
    }
    public void Fechar(){
      Object.SetActive(false);
      MovimentePlayer._canMove_Placa = true;
    }
}