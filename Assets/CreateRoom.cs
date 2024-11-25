using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CreateRoom : MonoBehaviourPunCallbacks
{

    [SerializeField] private TMP_Text textWithCodeForConnect;
    private string code;

    private void Start()
    {
        Debug.Log(GenerateRandomCode(8));
        code = GenerateRandomCode(8);
    }

    private string GenerateRandomCode(int length)
    {
        string chars = "qwertiopasjklzxcvbnmQWERTYUIOPASFGHJKLZXCVBNM1234567890";
        string code = "";
        
        for(int i = 0; i != length; i++)
        {
            code += chars[Random.Range(0, chars.Length)];
        }
        return code;
    }


    public void CreateActiveRoom()
    {
        RoomOptions roomOptions = new RoomOptions();
        roomOptions.IsVisible = false;
        roomOptions.MaxPlayers = 16;
        textWithCodeForConnect.text = code;
        PhotonNetwork.CreateRoom(code, roomOptions, TypedLobby.Default);
    }
}
