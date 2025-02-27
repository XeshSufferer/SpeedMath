using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ConnectToMaster : MonoBehaviourPunCallbacks
{

    [SerializeField] private GameObject WhiteScreen;
    [SerializeField] private Passwords passwords;
    [SerializeField] private TMP_InputField input;
    // Start is called before the first frame update
    private void Start()
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
        if(!CheckPassword()) return;
        SceneManager.LoadScene(1);
    }
    
    public void ToLessionWindow()
    {
        SceneManager.LoadScene(2);
    }

    private bool CheckPassword()
    {
        for(int i = 0; i != passwords.PasswordsList.Length; i++)
        {
            if(input.text.ToLower() == passwords.PasswordsList[i].ToLower())
            {
                return true;
            }
        }
        return false;
    }
}
