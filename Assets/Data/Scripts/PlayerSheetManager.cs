using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerSheetManager : MonoBehaviour
{
    [SerializeField] private Player[] playerList;
    [SerializeField] private GameObject ninjaTable;
    private int _positionsTaken = 0;

    [PunRPC]
    private void AddResult(int result, string identifier)
    {
        playerList[_positionsTaken].Result = result;
        playerList[_positionsTaken].Identifier = identifier;
        _positionsTaken++;
        ninjaTable.SetActive(false);
    }

}
