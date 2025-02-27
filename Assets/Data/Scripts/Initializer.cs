using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using System;

public class Initializer : MonoBehaviour
{
    
    [SerializeField] private EventUser startGameEvent;
    [SerializeField] private MathGenerator mathGenerator;
    
    private int _time;

    /*private void Start()
    {
        //GetSettings(false, false, false, true, "10", "100", "10", "100", "10", "100", "10", "100", 600);
    }*/

    [PunRPC]
    public void GetSettings(bool plus, bool minus, bool division, bool multiplicaton,
    string plus_min, string plus_max, string minus_min, string minus_max, string division_min, string division_max, string multiplicaton_min, string multiplicaton_max, int time)
    {
        mathGenerator.plus_min = plus_min != "" ? Int32.Parse(plus_min) : 0;
        mathGenerator.plus_max = plus_max != "" ? Int32.Parse(plus_max) : 0;

        mathGenerator.minus_min = minus_min != "" ? Int32.Parse(minus_min) : 0;
        mathGenerator.minus_max = minus_max != "" ? Int32.Parse(minus_max) : 0;

        mathGenerator.division_min = division_min != "" ? Int32.Parse(division_min) : 0;
        mathGenerator.division_max = division_max != "" ? Int32.Parse(division_max) : 0;
        
        mathGenerator.multiplicaton_min = multiplicaton_min != "" ? Int32.Parse(multiplicaton_min) : 0;
        mathGenerator.multiplicaton_max = multiplicaton_max != "" ? Int32.Parse(multiplicaton_max) : 0;

        mathGenerator.minus = minus;
        mathGenerator.plus = plus;
        mathGenerator.division = division;
        mathGenerator.multiplicaton = multiplicaton;

        _time = time;

        startGameEvent.window.SetActive(true);
        StartOtschet();
    }

    private void StartOtschet() => StartCoroutine(mathGenerator.Otschet(_time));

}
