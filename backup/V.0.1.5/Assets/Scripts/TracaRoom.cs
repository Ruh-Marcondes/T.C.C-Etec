using UnityEngine;

public class TracaRoom : MonoBehaviour {
    
int vez;
public GameObject Object;
private void OnTriggerEnter2D(Collider2D other) {
    if(other.gameObject.tag == "Player"){
        Object.GetComponent<CameraMovimente_Masmorra>().Room2Villa();
    }
}
}