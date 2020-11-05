using UnityEngine;

public class TrocaRoom2 : MonoBehaviour {
    
private int vez = 0;
public GameObject Object;

private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.tag == "Player"){
        if(vez == 0){
             Object.GetComponent<CameraMovimente_Masmorra>().Room3Villa();
             vez++;
        }else{
            vez --;
             Object.GetComponent<CameraMovimente_Masmorra>().Room2Villa();
        }
       
    }
}
}