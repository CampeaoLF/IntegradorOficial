using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager : MonoBehaviour
{
    public int pontos = 0;

    public void GanhaPonto(int value)
    {
        pontos = pontos + value; 
    }

}
