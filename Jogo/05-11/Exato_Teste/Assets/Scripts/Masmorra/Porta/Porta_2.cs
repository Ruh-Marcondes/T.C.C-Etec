using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Porta_2 : MonoBehaviour
{
    public GameObject player, cam;
    private int azul,azulAmarelo;
    public Animator animator;   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player"){
            if(NCP_Room2.TOTAL_AZUL<=0 && NCP_Room2 .TOTAL_Azul_AMARELO <=0){
                animator.SetTrigger("Change_Room");
                player.GetComponent<MovimentePlayer>().Room3_Masmorra();
                cam.GetComponent<CameraMovimente_Masmorra>().Room3Masmorra();   
            }
        }
    }
}