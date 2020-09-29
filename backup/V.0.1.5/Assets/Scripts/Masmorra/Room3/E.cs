using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E : MonoBehaviour
{
   public GameObject Object;

   void Start()
   {
      Object.SetActive(false); 
   } 

private void OnTriggerEnter2D(Collider2D other) {
   if(other.gameObject.tag == "Player"){
      Object.SetActive(true);
        Placa2Masmorra.platercantmove = false;
   }
 }
    
  public void fechar(){
        Object.SetActive(false);
        Placa2Masmorra.platercantmove = true;
  }
}