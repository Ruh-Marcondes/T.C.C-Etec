using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoviment : MonoBehaviour
{
     
    public Transform target; // para seguir o objeto 
    public float smoothing; // o qual rapido ela vai seguir 
    void Start()
    {

        
    }
    void LateUpdate()
    {
        if(transform.position != target.position){
            Vector3 targetPosition = new Vector3(target.position.x,target.position.y - 0.5f,transform.position.z);
            transform.position = Vector3.Lerp(transform.position,targetPosition,smoothing);
        }
    }
}
