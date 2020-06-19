using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D rig;
    private Vector3 change;
    private Animator anime;
    
    
    
    void Start(){
        
        rig = GetComponent<Rigidbody2D>();
        anime = GetComponent<Animator>();
       
    }

    void Update(){
         change = Vector3.zero;
         change.x = Input.GetAxisRaw("Horizontal");
         change. y = Input.GetAxisRaw("Vertical"); // GetAxisRaw - da os numeros apenas como (0,1,-1)
         //Debug.Log(change);
        UpdateAnimeMove();
    }
     void UpdateAnimeMove() {
         if(change != Vector3.zero){ // assim ele ñ fica chamando a função toda hr só quando o player se mexer
            MovePlayer();
            anime.SetFloat("moveX",change.x);
            anime.SetFloat("moveY",change.y);
            anime.SetBool("Move",true);
        }else{
            anime.SetBool("Move",false);
        }
    }
    void MovePlayer(){
        rig.MovePosition(
            transform.position + change*Speed* Time.deltaTime
        );// Mover o player  em qualquer direção 
      
    }

    void OnCollisionEnter2D(Collision2D collision){ // quando o objeto toca em algo 
    }
    void OnCollisionExit2D(Collision2D collision){ // quando o objeto para de tocar em algo    
    }
}
