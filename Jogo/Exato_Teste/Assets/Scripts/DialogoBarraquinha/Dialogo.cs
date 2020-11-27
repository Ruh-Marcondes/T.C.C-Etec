using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogo : MonoBehaviour
{
    public FalaNPC[] falas = new FalaNPC[2];


    private bool dialogoConcluido = false;

    DialogoControllor dialogoControllor;
 void Start() {
     dialogoControllor = FindObjectOfType<DialogoControllor>();

}
    

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player"){
             MovimentePlayer._canMove_Placa = false;

             if(!dialogoConcluido){
                 dialogoControllor.ProximaFala(falas[0]);
             }else{
                 dialogoControllor.ProximaFala(falas[1]);
             }
             dialogoConcluido = true;
        }
    }
}
