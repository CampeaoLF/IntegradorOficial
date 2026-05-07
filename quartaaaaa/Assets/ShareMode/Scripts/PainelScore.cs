using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Fusion;

public class PainelScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText; 


    void Update()
    {
        UpdateScore();
    }

    void UpdateScore()
    {
        string score = "=== Score ===\n";
        NetworkObject[] todosObjetos = FindObjectsOfType<NetworkObject>();
        
        int playerNumber = 1;

        foreach (NetworkObject networkObj in todosObjetos)
        {
            MovementController player = networkObj.GetComponent<MovementController>();

            if (player != null)
            {

                string marcador = networkObj.HasInputAuthority ? " (VOCÊ)" : "";
                score += $"Player {playerNumber}{marcador}: {player.Score} pontos\n";
                playerNumber++;

            }    
            
        }

        scoreText.text = score;

    }

}
