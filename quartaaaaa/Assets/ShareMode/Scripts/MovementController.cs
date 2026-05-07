using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fusion;

public class MovementController : NetworkBehaviour
{

    [SerializeField] public CharacterController characterController;
    [SerializeField] public float velocidade = 5f;
    [SerializeField] public Animator playerAnimator;

    [Networked] public int Score { get; set; }

    [Rpc(RpcSources.All, RpcTargets.StateAuthority)]
    public void RPC_AddScore(int points)
    {
        Score += points;
    }

    public void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    public override void FixedUpdateNetwork()
    {
        if (HasStateAuthority)
        {
            float horizontal = Input.GetAxis("Horizontal"); 
            float vertical = Input.GetAxis("Vertical");

            Vector3 direcao = new Vector3 (horizontal, 0f, vertical);
            if (direcao.magnitude > 0.1f)
            {
                #region primeiro formato de movimento
                ////Movimento
                //characterController.Move(direcao * velocidade * Runner.DeltaTime);
                ////Rotacao
                //transform.rotation = Quaternion.LookRotation(direcao);
                #endregion

                #region segundo formato de movimento
                //Movimento do personagem "tanque"
                characterController.Move(transform.forward * vertical * velocidade * Runner.DeltaTime);
                //Rotacao do personagem
                float rotateSpeed = velocidade * 50f;
                transform.Rotate(new Vector3(0, horizontal * rotateSpeed * Runner.DeltaTime, 0));
                #endregion

                //animacao andando
                playerAnimator.SetBool("canWalk", true);
            }
            else
            {

                //animacao parada
                playerAnimator.SetBool("canWalk", false);

            }


        }
    }

}
