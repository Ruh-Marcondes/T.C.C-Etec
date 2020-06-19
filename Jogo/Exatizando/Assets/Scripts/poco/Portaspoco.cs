using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Portaspoco : MonoBehaviour {

    // ID - 1: Desafio;
    // ID - 2: Mostra msg - não pode entar; 
    // ID - 3: Porta 24
    // ID - 4: Porta 13 - Pode Passar
    // ID - 5: Porta 55 


    #region  - number
    public int ID;
    private float tempoespera = 0.7f;
    #endregion 
    #region - String
    public string scnenxt;
    public string thislevel;
    public Text numporta;
    #endregion
    #region - GameObject
    public GameObject txt;
    public GameObject perdi;
    public GameObject transition;
    #endregion
    void OnCollisionEnter2D(Collision2D collision){ // quando o objeto toca em algo 
        if(collision.gameObject.tag == "Player"){
            switch(ID){
                #region Scene_1
                case 1:
                    Debug.Log("Bateu na porta de desafio");
                    transition.SetActive(true);
                   StartCoroutine("loading");

                break;
               
                case 2:
                    Debug.Log("Bateu na Porta do começo");
                    txt.SetActive(true);
                    StartCoroutine("espere");
                   
                break;
                #endregion
                case 3:
                numporta.text = "Tem certeza que quer abrir a porta num 24";
                txt.SetActive(true);
                StartCoroutine("espere");

                break;

                case 4:
                numporta.text = "Tem certeza que quer abrir a porta num 13";
                txt.SetActive(true);
                StartCoroutine("loadingP13");

                break;

                case 5:
                numporta.text = "Tem certeza que quer abrir a porta num 55";
                txt.SetActive(true);
                StartCoroutine("espere");

                break;
                
            }
        }
        }
    IEnumerator perdeu(){
                perdi.SetActive(true);
                yield return new WaitForSeconds(tempoespera);
                SceneManager.LoadScene(thislevel);
        }
    IEnumerator espere(){
        yield return new WaitForSeconds(tempoespera);
         txt.SetActive(false);
         StartCoroutine("perdeu");
    }
    IEnumerator loadingP13(){
         yield return new WaitForSeconds(tempoespera);
         numporta.text = "Muito Bem vc Acertou";
         txt.SetActive(true);
         yield return new WaitForSeconds(tempoespera);
         txt.SetActive(false);
        transition.SetActive(true);
         SceneManager.LoadScene(scnenxt);
    }
    IEnumerator loading(){
        yield return new WaitForSeconds(tempoespera);
        transition.SetActive(true);
        SceneManager.LoadScene("Zero21solitarie");
        
    }
    
}