using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerData data;
    public PlayerManager manager;

    new string name ;
    int lvl;

    void SetPlayer()
    {
        name = data.playersModelsList[0].name;
        lvl = data.playersModelsList[0].lvl;

    }

   
}
