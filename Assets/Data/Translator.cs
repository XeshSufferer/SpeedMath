using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Translator : MonoBehaviour
{

    private bool RU = false;

    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text myText;


    public void Switch()
    {
        RU = !RU;

        if(RU)
        {
            text.text = "Нажмите любую кнопку для начала игры";
            myText.text = "RU";
        }
        else
        {
            text.text = "Press any key for start";
            myText.text = "EN";
        }
    }
}
