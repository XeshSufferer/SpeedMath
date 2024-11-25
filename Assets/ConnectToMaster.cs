using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConnectToMaster : MonoBehaviourPunCallbacks
{

    [SerializeField] private GameObject WhiteScreen;
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log($"connected to {PhotonNetwork.CloudRegion}");
        WhiteScreen.SetActive(false);
    }

    public void ToTeacherWindow()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ToLessionWindow()
    {
        SceneManager.LoadScene(2);
    }
}
