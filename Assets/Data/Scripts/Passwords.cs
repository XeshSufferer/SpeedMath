using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passwords : MonoBehaviour
{
    public string[] PasswordsList 
    {

        get { return passwordsList; }

        private set { passwordsList = value; } 

    }

    [SerializeField] private string[] passwordsList;
}
