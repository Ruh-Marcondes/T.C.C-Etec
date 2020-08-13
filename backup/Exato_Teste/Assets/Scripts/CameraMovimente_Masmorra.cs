using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovimente_Masmorra : MonoBehaviour
{
    public Transform target;
    public float smooothing;
    public Vector2 maxPosition;
    // -5.42  4.17
    public Vector2 minPosition;
    //-8.04 -1.5
    
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
        maxPosition = PosicoesCamera.Max_Room3_Masmorra;
        minPosition = PosicoesCamera.Min_Room3_Masmorra;
    }
}
