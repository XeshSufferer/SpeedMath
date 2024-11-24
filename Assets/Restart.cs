using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    [SerializeField] private MathGenerator mathGenerator;
    [SerializeField] private Timer timer;
    [SerializeField] private SaveProgressSys saver;

    private void Update()
    {
        if(Input.GetKey("escape"))
        {
            if(saver.GetSaveCoef() < mathGenerator.Resheno / Mathf.Round(timer.timer))
            {
                saver.Save();
            }
            SceneManager.LoadScene(0);
        }
    }
}
