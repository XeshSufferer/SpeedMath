using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{

    private TMP_Text timer_text;
    private bool started;
    public float timer;

    private void Start()
    {
        timer_text = gameObject.GetComponent<TMP_Text>();
    }

    public void StartTimer()
    {
        StartCoroutine(TimerCoroutine());
    }

    private IEnumerator TimerCoroutine()
    {
        started = true;
        while(started)
        {
            yield return new WaitForSeconds(1f);
            timer++;
            timer_text.text = $"{timer}";
        }
    }
}
