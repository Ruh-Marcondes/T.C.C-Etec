using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NCP_Room2 : MonoBehaviour{
    public static int TOTAL_AZUL = 1;
    public static int TOTAL_Azul_AMARELO = 1;
    public Sprite green;
    
    void OnCollisionEnter2D(Collision2D other)
    {
            if(gameObject.tag=="Azul"){
                Destroy(this.gameObject,.5f);
               TOTAL_AZUL -= 1;
            }
            if(gameObject.tag=="AzulAmarelo"){
                
                this.gameObject.GetComponent<SpriteRenderer>().sprite = green;
                TOTAL_Azul_AMARELO -= 1;
            }
        }
}
    
