using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Build.Content;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int pontos = 0;
    //public GameManager gameManager;
    public GameObject player;

    private void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            ItemCollect coleta = other.GetComponent<ItemCollect>();

            if (coleta != null)
            {
                GanhaPonto(coleta.valor);
            }

            Destroy(other.gameObject);

        }
    }

    public void GanhaPonto(int value)
    {
        pontos = pontos + value;
    }
}
