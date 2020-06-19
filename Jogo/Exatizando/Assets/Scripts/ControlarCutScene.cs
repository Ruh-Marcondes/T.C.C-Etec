using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class ControlarCutScene : MonoBehaviour
{
    private bool fix = false;

    private string leval_1;
    public PlayableDirector directior;
    // Start is called before the first frame update
    void Start()
    {
       
        leval_1 = "scene_1";
    }

    // Update is called once per frame
    void Update()
    {
        if(directior.state != PlayState.Playing && !fix){

            fix = true;
            SceneManager.LoadScene(leval_1);
        }
    }
}
