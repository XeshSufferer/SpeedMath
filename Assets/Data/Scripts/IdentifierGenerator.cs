using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentifierGenerator : MonoBehaviour
{
    [SerializeField] private string[] wordsList;

    [System.NonSerialized] public string Identifier;

    private string GetRandomWord() 
    {
        return wordsList[Random.Range(0, wordsList.Length)];
    }

    private void Start()
    {
        Identifier = GetRandomWord() + GetRandomWord();
        gameObject.GetComponent<TMPro.TMP_Text>().text = Identifier;
    }


    private int StressTest()
    {
        string mainCode = GetRandomWord() + GetRandomWord();
        int index = 0;
        string word = "";
        while(mainCode != word)
        {
            for(int i = 0; i != 16; i++)
            {
                word = GetRandomWord() + GetRandomWord();
                if(mainCode == word) break;
            }
            index++;
        }
        return index;
    }
}
