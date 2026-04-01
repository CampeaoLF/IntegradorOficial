using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public GameManager gameManager;

    [Header("Botões de movimento base")]
    [SerializeField] public Button[] buttonsMoveBase;

    [Header("Botão de movimento especial")]
    [SerializeField] public GameObject buttonMoveSpecial;

    [Header("Sprite")]
    [SerializeField] public Sprite[] sprites;
    [SerializeField] public Sprite[] cenario;


    void Start()
    {



    }


    void Update()
    {

        if (gameManager.score >= 5 && cenario[0])
        {

            var scenarioAtual = gameManager.background.GetComponent<SpriteRenderer>();
            scenarioAtual.sprite = cenario[0];
        }
        if (gameManager.score >= 10 && cenario[1])
        {
            var scenarioAtual = gameManager.background.GetComponent<SpriteRenderer>();
            scenarioAtual.sprite = cenario[1];
        }



    }

    public void ClickMoveBaseFirst(Button botao)
    {
        

        if (Input.touchCount == 1 && buttonsMoveBase[0])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[0];
            gameManager.GainPoints(1);
            
        }
        
    }

    public void ClickMoveBaseSecond()
    {
        if (Input.touchCount == 1 && buttonsMoveBase[1])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[1];
            gameManager.GainPoints(5);

        }

    }

    public void ClickMoveBaseThird()
    {
        if (Input.touchCount == 1 && buttonsMoveBase[2])
        {
            
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[2];
            gameManager.GainPoints(5);

        }

    }

    public void ClickMoveBaseSpecial(Button botao)
    {
        if (Input.touchCount == 1 && buttonMoveSpecial)
        {
            var spriteAtual = player.GetComponent<SpriteRenderer>();
            spriteAtual.sprite = sprites[3];
            gameManager.GainPoints(10);
        }
    }


}
