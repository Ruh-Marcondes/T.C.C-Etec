﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Y : MonoBehaviour
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