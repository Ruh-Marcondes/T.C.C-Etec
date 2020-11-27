using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativos : MonoBehaviour
{
   public GameObject  room2, room3,canvas;

    public  void DestrRoom2(){
        Destroy(room2,.5f);
   }
    public  void DestrRoom3(){
        Destroy(room3,.5f);
         Destroy(canvas,.5f);
   }
}
