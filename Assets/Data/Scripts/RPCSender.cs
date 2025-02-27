using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;
using Photon.Realtime;
using System;

public class RPCSender : MonoBehaviour
{
    [SerializeField] private PhotonView view;
    [SerializeField] private TMP_InputField InputTIME;

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
    
    [Space(10f)]
    [SerializeField] private GameObject button;


    public void BuildSettigs()
    {
        view.RPC("GetSettings", RpcTarget.AllBuffered,
        DropdownPLUS.isOn, DropdownMINUS.isOn, DropdownDIVISION.isOn, DropdownMULTIPLICATION.isOn,
        InputPLUS_MIN.text, InputPLUS_MAX.text, InputMINUS_MIN.text, InputMINUS_MAX.text,
        InputDIVISION_MIN.text, InputDIVISION_MAX.text, InputMULTIPLICATION_MIN.text, InputMULTIPLICATION_MAX.text, InputTIME.text != "" ? Int32.Parse(InputTIME.text) : 100);

        button.SetActive(false);
    }

}
