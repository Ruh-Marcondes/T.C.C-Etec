using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BauControl : MonoBehaviour
{
    public int bau;
    public static bool frist = false, second = false;
    void OnCollisionEnter2D(Collision2D other)
    {
       if (other.gameObject.tag == "Player")
        {
            switch(bau){
                case 1:
                frist = true;

                break;
                case 2:
                second = true;
                break;
            }
        } 
    }
}
