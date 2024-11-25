using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBlinker : MonoBehaviour
{
    [SerializeField] private float blinkDelay;
    private TMP_Text _selfText;

    private void Start()
    {
        _selfText = gameObject.GetComponent<TMP_Text>();
        StartCoroutine(BlinkCycle());
    }

    private IEnumerator BlinkCycle()
    {
        while(true)
        {
            yield return new WaitForSeconds(blinkDelay);
            _selfText.enabled = !_selfText.enabled;
        }
    }

}
