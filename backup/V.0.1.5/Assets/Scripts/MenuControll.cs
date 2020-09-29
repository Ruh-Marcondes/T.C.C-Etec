using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuControll : MonoBehaviour
{
   private bool show = false;
   public GameObject menu;

   void Start()
   {
       menu.SetActive(show);
   }
   
   void Update()
   {
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            show = !show;
            Book_Controller.PlayerCanMove = !Book_Controller.PlayerCanMove;
            menu.SetActive(show); 
        }   
       
   }

  public void FecharAplication(){
        Application.Quit();
  }
}
