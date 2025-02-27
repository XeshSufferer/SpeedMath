using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class MathGenerator : MonoBehaviour
{
    [SerializeField] private IdentifierGenerator identifier;
    [SerializeField] private GameObject bahObject;
    [SerializeField] private PhotonView view;
    [SerializeField] private TMP_InputField input;

    [SerializeField] private TMP_Text math1_TEXT;
    [SerializeField] private TMP_Text math2_TEXT;
    [SerializeField] private TMP_Text Znak_TEXT;

    [SerializeField] private TMP_Text Resheno_TEXT;

    [SerializeField] private float TrueAnswer;

    public int Resheno;


    [System.NonSerialized] public bool division;
    [System.NonSerialized] public bool plus;
    [System.NonSerialized] public bool minus;
    [System.NonSerialized] public bool multiplicaton;



    [System.NonSerialized] public int plus_max;
    [System.NonSerialized] public int plus_min;

    [System.NonSerialized] public int minus_max;
    [System.NonSerialized] public int minus_min;

    [System.NonSerialized] public int division_max;
    [System.NonSerialized] public int division_min;

    [System.NonSerialized] public int multiplicaton_max;
    [System.NonSerialized] public int multiplicaton_min;

    [System.NonSerialized] private int math_1 = 0;
    [System.NonSerialized] private int math_2 = 0;

    private void Start()
    {
        GenerateMath();
    }

    public void GenerateMath()
    {

        if(Random.Range(0, 5) == 1 && plus)
        {
            math_1 = (int)Random.Range(plus_min, plus_max + 1);
            math_2 = (int)Random.Range(plus_min, plus_max + 1);

            TrueAnswer = math_1 + math_2;
            Znak_TEXT.text = "+";
        }
        else if(Random.Range(0, 5) == 2 && minus)
        {
            math_1 = (int)Random.Range(minus_min, minus_max + 1);
            math_2 = (int)Random.Range(minus_min, minus_max + 1);

            if((math_1 - math_2) < 0)
            {
                GenerateMath();
                return;
            }
            TrueAnswer = math_1 - math_2;
            Znak_TEXT.text = "-";
        }
        else if(Random.Range(0, 5) == 3 && multiplicaton)
        {
            math_1 = (int)Random.Range(multiplicaton_min, multiplicaton_max + 1);
            math_2 = (int)Random.Range(multiplicaton_min, multiplicaton_max + 1);

            TrueAnswer = math_1 * math_2;
            Znak_TEXT.text = "*";
        }
        else if(Random.Range(0, 5) == 4 && division)
        {
            math_1 = (int)Random.Range(division_min, division_max + 1);
            math_2 = (int)Random.Range(division_min, division_max + 1);

            if((math_1 % math_2) != 0 || math_1 / math_2 == 1)
            {
                GenerateMath();
                return;
            }
            TrueAnswer = math_1 / math_2;
            Znak_TEXT.text = "/";
        }
        else
        {
            GenerateMath();
            return;
        }

        math1_TEXT.text = $"{math_1}";
        math2_TEXT.text = $"{math_2}";
        Resheno_TEXT.text = $"{Resheno}";


    }

    public void AnswerAnalys()
    {
        if(input.text == $"{TrueAnswer}" || input.text == "venom")
        {
            input.text = "";
            Resheno++;
            GenerateMath();
        }
    }

    public IEnumerator Otschet(int time)
    {
        yield return new WaitForSeconds(time);
        view.RPC("AddResult", RpcTarget.MasterClient, Resheno, identifier.Identifier);
        bahObject.SetActive(true);
    }
}
