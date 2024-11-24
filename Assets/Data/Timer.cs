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

    private void Update()
    {
        if(!started) return;
        timer += Time.deltaTime;
        timer_text.text = $"{Mathf.Round(timer)}";
    }

    public void StartTimer()
    {
        started = true;
    }

    private IEnumerator TimerCoroutine()
    {
        while(true)
        {
            yield return new WaitForSeconds(1f);
            timer++;
            timer_text.text = $"{timer}";
            if(!started) yield break;
        }
    }
}
