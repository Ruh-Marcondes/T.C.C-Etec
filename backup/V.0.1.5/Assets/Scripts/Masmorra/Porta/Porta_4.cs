using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Porta_4 : MonoBehaviour
{
    public Animator animator;   
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(NextLevel(1));
           
        }
        IEnumerator NextLevel(int levelIndex){
         animator.SetTrigger("Change_Scene");
         yield return new WaitForSeconds(levelIndex);
           SceneManager.LoadScene(2);
    }
    }
}
