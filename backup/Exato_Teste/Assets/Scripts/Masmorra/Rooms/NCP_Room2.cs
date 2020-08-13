using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NCP_Room2 : MonoBehaviour{
    public static int TOTAL_AZUL = 1;
    public static int TOTAL_AMARELO = 1;
    
        void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player"){
            if(gameObject.tag=="Amarelo"){
                MoveParaAmarelo();
                TOTAL_AMARELO--;
                
            }
            if(gameObject.tag=="Azul"){
                MoveParaAzul();
                TOTAL_AZUL--;
               
            }
        }
    }
     public void MoveParaAmarelo(){
        transform.position = new Vector3(Random.Range(-10f,-5f),Random.Range(9f,11f),0.0f);
    }
     public void MoveParaAzul(){
        transform.position = new Vector3(Random.Range(-1f,2f),Random.Range(9f,12f),0.0f);
    }
}