using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimente_Masmorra : MonoBehaviour
{
    public Transform target;
    public float smooothing;
    public Vector2 maxPosition;
    public Vector2 minPosition;
    
    
    
    void LateUpdate(){
        if(transform.position != target.position){
            Vector3 targetPosition = new Vector3(target.position.x,target.position.y,transform.position.z);
            targetPosition.x = Mathf.Clamp(targetPosition.x,minPosition.x,maxPosition.x);
            targetPosition.y = Mathf.Clamp(targetPosition.y,minPosition.y,maxPosition.y);
            transform.position = Vector3.Lerp(transform.position,targetPosition,smooothing);
        }
    }
    public void Room2Masmorra(){
        maxPosition =  PosicoesCamera.MaxPositionRoom2_Masmorra;
        minPosition = PosicoesCamera.MinPositinRoom2_Masmorra;
    }
    public void Room2MasmorraNew(){
        maxPosition = PosicoesCamera.NewMaxPositionRoom2_Masmorra;
        minPosition = PosicoesCamera.NewMinPositinRoom2_Masmorra;
    }
    public void Room3Masmorra(){
        this.GetComponent<Ativos>().DestrRoom2();
        maxPosition = PosicoesCamera.Max_Room3_Masmorra;
        minPosition = PosicoesCamera.Min_Room3_Masmorra;
    }
    public void Room4Masmorra(){
        this.GetComponent<Ativos>().DestrRoom3();
        maxPosition = PosicoesCamera.Max_Room4_Masmorra;
        minPosition = PosicoesCamera.Min_Room4_Masmorra;
    }
    public void Room2Villa(){
        maxPosition = PosicoesCamera.Max_Roo2_Villa;
        minPosition = PosicoesCamera.Min_Roo2_Villa;
    }
    public  void Roo1Villa(){
        maxPosition = new Vector2(44f,27f);
        minPosition = new Vector2(35f,2f);
    }
    public void Room3Villa(){
        maxPosition = new Vector2(25,24);
        minPosition = new Vector2(12,15);
    }

}

