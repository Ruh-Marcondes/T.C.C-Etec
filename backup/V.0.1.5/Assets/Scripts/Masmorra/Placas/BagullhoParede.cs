using UnityEngine;
using UnityEngine.UI;


public class BagullhoParede : MonoBehaviour {
    
    public  GameObject Senhaobj;
     public InputField ok;
    public static bool SenhaCerta = false;

private void Start() {
    Senhaobj.SetActive(false);
}

private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.tag == "Player"){
        Senhaobj.SetActive(true);
        Placa2Masmorra.platercantmove = false;
    }
}
     public void verificaSenha(){
        string senha;
        senha = ok.text.ToUpper();
        if(senha != "GREGORY"){
            ok.text = "";
            senha = "";
        }else{
            Placa2Masmorra.platercantmove = true;
            SenhaCerta = true;
            Senhaobj.SetActive(false);
        }
        
    }
    public void CloseSenha(){
        Placa2Masmorra.platercantmove = true;
        Senhaobj.SetActive(false);
    }
}