﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_1 : MonoBehaviour
{
    public GameObject camera_;
    public GameObject player;
    public bool _tocou_placa;
    public Animator animator;
    void Update()
    {
        _tocou_placa = Placa_Masmorra_controller.playertocou;
    }
   void OnCollisionEnter2D(Collision2D other)
   {
       if(other.gameObject.tag == "Player" && _tocou_placa ){ 
           animator.SetTrigger("Change_Room");
           player.GetComponent<MovimentePlayer>().Room2_Masmorra();
           camera_.GetComponent<CameraMovimente_Masmorra>().Room2Masmorra();
           
        }
   }
}
