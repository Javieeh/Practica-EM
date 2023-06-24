using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public string PlayerName { get; private set; }
    public int characterSelectedId { get; private set; } // 0 = huntress, 1 = akai, 2 = oni
    public PlayerData(string playerName, int id)
    {
        PlayerName = playerName;    
        characterSelectedId = id;
    }
    

}
