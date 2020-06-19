using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerCartas : MonoBehaviour
{
    #region 
    private int[] opc1 = new int[] {-3,-1,+5,-3,+2,+1,-4,+8,-5};
    private int[] opc2 = new int[] {+4,-6,+7,-8,+3,+2,-7,+6,-2};
    private int jogada = 0;
    #endregion
    #region 
    private int num;
    public Text txtopc1;
    public Text txtopc2;
    public Text txtnum;
    #endregion
    public GameObject sound;
    void Start()
    {
        num = 10;
        txtopc2.text = opc2[jogada].ToString();
        txtopc1.text = opc1[jogada].ToString();
        txtnum.text = num.ToString();
    }
    public void MudaCartaOpc1(){
        if(jogada < 8){   
            num += opc1[jogada];
           jogadanow();
        }else{
            venceu();
        }
    }
        
    public void MudaCartaOpc2(){
         if(jogada < 8){
                num += opc2[jogada];
               jogadanow();
            }
        else{
            venceu();
        }

    }

    void jogadanow(){
         if(num > 0 && num< 21){
                    jogada++;
                    txtopc1.text = opc1[jogada].ToString();
                    txtopc2.text = opc2[jogada].ToString();
                    txtnum.text = num.ToString();
                }else{
                youLost();
            }
    }
    void youLost(){
        sound.SetActive(true);
        txtnum.text = num.ToString();
        txtopc2.text = "-";
        txtopc1.text = "-";
        Debug.Log("You Lost");
        Debug.Log(num);

    }
    void venceu(){
         SceneManager.LoadScene("Scene_2");
    }
}
