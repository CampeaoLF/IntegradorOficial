using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class PlayerSpawner : SimulationBehaviour, IPlayerJoined
{
    [SerializeField] public GameObject playerPrefab;

    public void PlayerJoined(PlayerRef player)
    {
        if (player == Runner.LocalPlayer)
        {
            var objetoDaRede = Runner.Spawn(playerPrefab, Vector3.zero, Quaternion.identity, player); // prefab escolhido, position 0,0,0 , rotação padrão e autoridade de Input

            Runner.SetPlayerObject(player, objetoDaRede);

        }
        
    }

}
