using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Linq;

public class ChooseAnim : MonoBehaviour
{
    private string animation;
    private bool value;

    public List<GameObject> bottonSpecial;
    public List<GameObject> bottonsimple;
    public List<GameObject> bottonNormal;

    public GameObject simpleSelect;
    public GameObject normalSelect;
    public GameObject specialSelect;

    public int qtdSimple;
    public int qtdNormal;
    public int qtdSpecial;

    public string[] movsTags;

    


    public void ChooseSimple()
    {
        if (Input.touchCount == 1)
        {

            string[] movSimple = { "SMov1", "SMov2", "SMov3", "SMov4", "SMov5" };



            if (movSimple == null) return;
            else if (movSimple.Contains("SMov1"))
            {
                simpleSelect.SetActive(false);
                normalSelect.SetActive(true);
            }
          


        }
    }

    public void ChooseNormal()
    {
        qtdNormal++;
        if (Input.touchCount == 1)
        {
            
            if (qtdNormal == null) return;
            else if (qtdNormal == 2)
            {
                simpleSelect.SetActive(false);
                normalSelect.SetActive(false);
                specialSelect.SetActive(true);
            }
            
        }
    }
    public void ChooseSpecial()
    {
        qtdSpecial++;

        if (qtdSpecial == null) return;
        else if (qtdSpecial == 1)
        {
            SceneManager.LoadScene("MainGame");
        }
  
    }
    void Start()
    {

    }
}


