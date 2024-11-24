using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveProgressSys : MonoBehaviour
{
    [SerializeField] private MathGenerator mathGenerator;
    [SerializeField] private Timer timer;

    private void Start()
    {
        //Debug_Save(0.00001f);
    }

    private void Debug_Save(float debug)
    {
        PlayerPrefs.SetFloat("coef", debug);
    }

    public void Save()
    {
        PlayerPrefs.SetFloat("coef",mathGenerator.Resheno / Mathf.Round(timer.timer));
    }

    public float GetSaveCoef()
    {
        return PlayerPrefs.GetFloat("coef", 0f);
    }
}
