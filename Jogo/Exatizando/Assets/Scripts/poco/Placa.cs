using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placa : MonoBehaviour
{

    private string[] avisos  = new string[]{"Bem Vindo a Exatizando","Você deve cumprir os desafios desse mundo para retornar ao seu"}; 
    public int ID;
    void Start()
    {
        

    }
    void Update()
    {
        
    }
    
     void OnCollisionEnter2D(Collision2D collision){ // quando o objeto toca em algo 
        if(collision.gameObject.tag == "Player"){
            switch(ID){
                case 1:
                Debug.Log(avisos[0]);
                break;
                case 2:
                Debug.Log("Este é o primeiro desafio");
                break;
            }
            
        }
    }
     void OnCollisionExit2D(Collision2D collision){
         Debug.Log("You are a baka des");

    }
}
