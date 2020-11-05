using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_3 : MonoBehaviour
{
      public GameObject player, cam;
      public Animator animator;   
    private bool a;
    // Update is called once per frame
    void Update()
    {
         a = BagullhoParede.SenhaCerta;
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
        
            if(a){
                animator.SetTrigger("Change_Room");
                player.GetComponent<MovimentePlayer>().Room4_Masmorra();
                cam.GetComponent<CameraMovimente_Masmorra>().Room4Masmorra();
            }
           
        }
    }
}