using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : Singelton<PlayerManager>
{
    
    public List<Player> playersList = new List<Player>();

    public void AddPlayer()
    {
        playersList.Add(playersList[0]);
    }
}
