
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumValidate : MonoBehaviour
{
    public InputField inputField;
    public int numVal;
    public void NumValudation()
    {
        string stringVal = inputField.text;
        numVal = int.Parse(stringVal);  

        if(numVal < 1 || numVal > 100)
        {
            Debug.Log("num not valid");
        }
        else
        {
            Debug.Log("Valid");
        }
    }
}
