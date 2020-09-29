using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Book_Controller : MonoBehaviour{

#region váriaveis
    private bool show = false, _true = true, _false = false;
    public GameObject gb;
    public GameObject book;
    public GameObject pedras;
    public int Pagina = 1;
    public GameObject[] pg = new GameObject [2];
    public static bool PlayerCanMove = true;
   #endregion
 void Start(){ 

    gb.SetActive(show); 
    book.SetActive(_true);
    fristpg();
    pedras.SetActive(_false);
}    
void Update()
{
   if(Input.GetKeyDown(KeyCode.LeftShift)){
        show = !show;
        PlayerCanMove = !PlayerCanMove;
        gb.SetActive(show);  
    } 
    if (Input.GetKeyDown(KeyCode.B) && show) ShowNotes();
    if(Input.GetKeyDown(KeyCode.P)&& show) ShowPedras();
    if(Input.GetKeyDown(KeyCode.RightArrow)&& show) ControleNotas_Afiter();
    if(Input.GetKeyDown(KeyCode.LeftArrow)&& show) ControleNotas_Back();
}
public void ShowPedras(){
    pedras.SetActive(_true);
    book.SetActive(_false);
    
}

 public void ShowNotes(){
    book.SetActive(_true);
     fristpg();
    pedras.SetActive(_false); 
}
public void ControleNotas_Back(){
if(Pagina==2){
    fristpg();
    Pagina--;
}
}
public void ControleNotas_Afiter(){
if(Pagina==1){
    Pagina++;
    secondpg();
} 

}
public void fristpg(){
    pg[0].SetActive(_true);
    pg[1].SetActive(_false);
}
public void secondpg(){
    pg[1].SetActive(_true);
    pg[0].SetActive(_false);
}
}