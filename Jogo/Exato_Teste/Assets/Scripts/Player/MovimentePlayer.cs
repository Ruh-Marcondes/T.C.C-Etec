﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentePlayer : MonoBehaviour
{
  public float speed;
    private Rigidbody2D _myRigidbody;
    private Vector3 _change;
    private Animator _animator;
    public static bool _canMove_Placa = true;
    
    void Start () {
        _myRigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
	}
	void Update () {
        _change = Vector3.zero;
        _change.x = Input.GetAxisRaw("Horizontal");
        _change.y = Input.GetAxisRaw("Vertical");
        
      
        Callanimation();
	}
    void Callanimation(){
        if(_change != Vector3.zero  && _canMove_Placa){
            _animator.SetBool("movendo",true);
            _animator.SetFloat("moveX",_change.x);
            _animator.SetFloat("moveY",_change.y);
             MoveCharacter();
        }else{
             _animator.SetBool("movendo",false);
        }   
    }
    void MoveCharacter(){
        _myRigidbody.MovePosition(transform.position + _change * speed * Time.deltaTime);
    }
    public void Room2_Masmorra(){
        transform.position = PlayerPositions.playerRoom2_Masmorra;
    }
    public void Room3_Masmorra(){
         transform.position = PlayerPositions.room3_Masmorra;
    }
     public void Room4_Masmorra(){
         transform.position = PlayerPositions.room4_Masmorra;
    }
}

