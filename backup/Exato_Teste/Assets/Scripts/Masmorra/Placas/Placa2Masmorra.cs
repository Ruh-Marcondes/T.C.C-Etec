using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placa2Masmorra : MonoBehaviour
{
    public Text tx;
    public GameObject alan;
    public int ID;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player"){
            if(ID==2){
            tx.text = "Para a porta se abrir arrume os Munls nos seus lugares";
            alan.SetActive(true);
            }
            if(ID==3){

            }
        }
    }
}
