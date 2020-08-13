using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placa_Masmorra_controller : MonoBehaviour
{
    public GameObject texto; 
    public static bool playertocou = false;
    

void Start()
{
    texto.SetActive(false);
}
        void OnCollisionEnter2D(Collision2D other){
        if(other.gameObject.tag=="Player"){
            playertocou = true;
            texto.SetActive(true);
        }
    }
    public void clickClose(){
        texto.SetActive(false);
    }

}