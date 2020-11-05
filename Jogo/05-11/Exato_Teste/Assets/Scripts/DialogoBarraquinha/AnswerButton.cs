using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  AnswerButton : MonoBehaviour
{
   
        Resposta respostadata;

    public void ProximaFala(){
        FindObjectOfType<DialogoControllor>().ProximaFala(respostadata.proximaFala);
    }

    public void Setup(Resposta resposta){
        respostadata = resposta;
    }
}
