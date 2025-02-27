using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[System.Serializable]
public class Player : MonoBehaviour
{

    [SerializeField] private TMP_Text resultText;
    [SerializeField] private TMP_Text identifierText;

    public string Identifier
    {
        get
        {
            return _identifier;
        }

        set
        {
            _identifier = value;
            identifierText.text = value;            
        }
    }

    public int Result 
    {
        get
        {
            return _result;
        }

        set
        {
            _result = value;
            resultText.text = $"{value}";
        }
    }

    private int _result;
    private string _identifier;


}
