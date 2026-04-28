using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseAnim : MonoBehaviour
{
    private string animation;
    private bool value;

    public List<GameObject> bottonSpecial;
    public List<GameObject> bottonsimple;
    public List<GameObject> bottonNormal;

    public int qtdAnim;



    public void ChooseAnimation()
    {
        if (Input.touchCount == 1)
        {
           

            List<GameObject> anim = new List<GameObject>();
            qtdAnim ++;

            if (qtdAnim == null) return;
            else if (qtdAnim == 4 )
            {
                SceneManager.LoadScene("MainGame");
            }
         
            
        }
    }
    void Start()
    {
        
        foreach (GameObject prefab in bottonNormal)
        {
            Instantiate(prefab, new Vector2(0,0), Quaternion.identity);
        }
    }
}


