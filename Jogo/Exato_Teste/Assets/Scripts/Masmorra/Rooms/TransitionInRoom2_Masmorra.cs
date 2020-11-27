using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  TransitionInRoom2_Masmorra :  MonoBehaviour {
public GameObject cam;
private bool _time = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="Player"){
            if(_time){
            cam.GetComponent<CameraMovimente_Masmorra>().Room2Masmorra();
            _time = !_time;
            }else{
               cam.GetComponent<CameraMovimente_Masmorra>().Room2MasmorraNew();
                _time = !_time;
            }
        }
    }
}