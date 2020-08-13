using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porta_Masmorra_2 : MonoBehaviour
{ 
    public GameObject player, cam;
       void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player"){
           if(NCP_Room2.TOTAL_AMARELO<=0 && NCP_Room2.TOTAL_AZUL <= 0){
               Debug.Log("Pode sair");
                player.GetComponent<MovimentePlayer>().Room3_Masmorra();
                cam.GetComponent<CameraMovimente_Masmorra>().Room3Masmorra();
           }else{
               Debug.Log("Você ainda ñ pegou todos os Mounls");
               Debug.Log("Ainda falta Mounls Amarelos: "+ NCP_Room2.TOTAL_AMARELO+"Azul: "+ NCP_Room2.TOTAL_AZUL);
           }
        }
    }
    
}
