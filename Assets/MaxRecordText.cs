using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MaxRecordText : MonoBehaviour
{
    [SerializeField] private SaveProgressSys SaveSys;

    private TMP_Text selfText;

    private void Start()
    {
        selfText = gameObject.GetComponent<TMP_Text>();

        selfText.text = $"{SaveSys.GetSaveCoef()}";
    }
}
