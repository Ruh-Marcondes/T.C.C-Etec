using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PassagenFinal : MonoBehaviour
{
    private bool um, dois;
    public Animator animator;
    private void OnTriggerExit2D(Collider2D other) {
        um = BauControl.frist;
        dois = BauControl.second;
        if(um && dois) {
             StartCoroutine(NextLevel(1));
        }
        
    }
    IEnumerator NextLevel(int levelIndex){
         animator.SetTrigger("Change_Scene");
         yield return new WaitForSeconds(levelIndex);
           SceneManager.LoadScene(3);
    }
}
