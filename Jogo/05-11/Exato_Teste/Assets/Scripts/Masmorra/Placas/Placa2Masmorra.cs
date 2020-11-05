using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Placa2Masmorra : MonoBehaviour
{
    public Text tx;
   
    public GameObject placa, NPC;
    public int ID;
    
    void Start()
    {
        NPC.SetActive(false);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag=="Player"){
            MovimentePlayer._canMove_Placa = false;
            if(ID==2){
            tx.text = "\"- Eu tenho a cor do cêu, e me assusto facilmente;\n\t- Eu tenho a cor do Sol, e sustos não entram na minha mente;\n\t- Tenho as duas cores e se me asustar fico verde \n E agora você nos vê\"";
            placa.SetActive(true);
            NPC.SetActive(true);
            }
            if(ID==3){
                tx.text = "Bem - Vindo ao Museu";
               placa.SetActive(true);
            }    
        }
        
    }
   
}