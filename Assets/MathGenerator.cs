using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MathGenerator : MonoBehaviour
{
    [SerializeField] private Vector2 Difficult;
    [SerializeField] private TMP_InputField input;

    [SerializeField] private TMP_Text math1_TEXT;
    [SerializeField] private TMP_Text math2_TEXT;
    [SerializeField] private TMP_Text Znak_TEXT;

    [SerializeField] private TMP_Text Resheno_TEXT;

    [SerializeField] private float TrueAnswer;

    public int Resheno;

    private int math_1;
    private int math_2;


    private void Start()
    {
        GenerateMath();
    }

    public void GenerateMath()
    {
        math_1 = (int)Random.Range(Difficult.x, Difficult.y);
        math_2 = (int)Random.Range(Difficult.x, Difficult.y);

        if(Random.Range(0, 3) > 1)
        {
            TrueAnswer = math_1 + math_2;
            Znak_TEXT.text = "+";
        }
        else
        {
            TrueAnswer = math_1 - math_2;
            Znak_TEXT.text = "-";
        }

        math1_TEXT.text = $"{math_1}";
        math2_TEXT.text = $"{math_2}";
        Resheno_TEXT.text = $"{Resheno}";


    }

    public void AnswerAnalys()
    {
        if(input.text == $"{TrueAnswer}")
        {
            input.text = "";
            Resheno++;
            GenerateMath();
        }
    }
}
