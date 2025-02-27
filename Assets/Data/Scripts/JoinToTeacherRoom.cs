using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine.UI;

public class JoinToTeacherRoom : MonoBehaviourPunCallbacks
{
    [SerializeField] private TMP_InputField Code;
    

    public void Connect()
    {
        PhotonNetwork.JoinRoom(Code.text);
    }

    public override void OnJoinedRoom()
    {
        SceneManager.LoadScene(2);
    }
}
