using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;

public class RPCSender : MonoBehaviour
{
    [SerializeField] private PhotonView view;

//  Max and min value
    [SerializeField] private TMP_InputField InputPLUS_MAX;
    [SerializeField] private TMP_InputField InputPLUS_MIN;

    [SerializeField] private TMP_InputField InputMINUS_MAX;
    [SerializeField] private TMP_InputField InputMINUS_MIN;

    [SerializeField] private TMP_InputField InputDIVISION_MAX;
    [SerializeField] private TMP_InputField InputDIVISION_MIN;

    [SerializeField] private TMP_InputField InputMULTIPLICATION_MAX;
    [SerializeField] private TMP_InputField InputMULTIPLICATION_MIN;

// On operations

    [SerializeField] private Toggle DropdownPLUS;
    [SerializeField] private Toggle DropdownMINUS;
    [SerializeField] private Toggle DropdownDIVISION;
    [SerializeField] private Toggle DropdownMULTIPLICATION;


    public void BuildSettigs()
    {
        view.RPC("GetSettings", RpcTarget.AllBuffered,
        DropdownPLUS.isOn, DropdownMINUS.isOn, DropdownDIVISION.isOn, DropdownMULTIPLICATION.isOn,
        InputPLUS_MIN.text, InputPLUS_MAX.text, InputMINUS_MIN.text, InputMINUS_MAX.text,
        InputDIVISION_MIN.text, InputDIVISION_MAX.text, InputMULTIPLICATION_MIN.text, InputMULTIPLICATION_MAX.text);
    }

    [PunRPC]
    private void GetSettings(bool plus, bool minus, bool division, bool multiplicaton,
    string plus_min, string plus_max, string minus_min, string minus_max, string division_min, string division_max, string multiplicaton_min, string multiplicaton_max)
    {
        Debug.Log($"{plus}");
    }
}
