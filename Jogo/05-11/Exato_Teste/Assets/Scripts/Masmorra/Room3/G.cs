using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class G : MonoBehaviour
{
    public GameObject Object,Numnaturais,inte,racionais,reais,irracionais;
  void Start()
  {
      Object.SetActive(false);
      Numnaturais.SetActive(false);
      inte.SetActive(false);
      racionais.SetActive(false);
      irracionais.SetActive(false);
      reais.SetActive(false);
  }
 
 private void OnTriggerEnter2D(Collider2D other) {
   if(other.gameObject.tag == "Player"){
      Object.SetActive(true);
        MovimentePlayer._canMove_Placa = false;
   }
 }
  public void Fechar(){
      Object.SetActive(false);
      Numnaturais.SetActive(false);
      inte.SetActive(false);
      racionais.SetActive(false);
      reais.SetActive(false);
      irracionais.SetActive(false);
       MovimentePlayer._canMove_Placa = true;
  }

  public void funcnaturais(){
      MovimentePlayer._canMove_Placa = false;
      Object.SetActive(false);
      Numnaturais.SetActive(true);
      inte.SetActive(false);
      racionais.SetActive(false);
      irracionais.SetActive(false);
      reais.SetActive(false);
  }
  public void funcInt(){
      MovimentePlayer._canMove_Placa = false;
      Object.SetActive(false);
      Numnaturais.SetActive(false);
      inte.SetActive(true);
      racionais.SetActive(false);
      irracionais.SetActive(false);
      reais.SetActive(false);
  }
  public void funcRacionais(){
      MovimentePlayer._canMove_Placa = false;
      Object.SetActive(false);
      Numnaturais.SetActive(false);
      inte.SetActive(false);
      racionais.SetActive(true);
      irracionais.SetActive(false);
      reais.SetActive(false);
  }
  public void funcIrracionais(){
      MovimentePlayer._canMove_Placa = false;
      Object.SetActive(false);
      Numnaturais.SetActive(false);
      inte.SetActive(false);
      racionais.SetActive(false);
      irracionais.SetActive(true);
      reais.SetActive(false);
  }
  public void funcReais(){
      MovimentePlayer._canMove_Placa = false;
      Object.SetActive(false);
      Numnaturais.SetActive(false);
      inte.SetActive(false);
      racionais.SetActive(false);
      irracionais.SetActive(false);
      reais.SetActive(true);
  }
}
