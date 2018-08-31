using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInfo : MonoBehaviour
{
    [SerializeField, TextArea(5, 10)]
    string textInfo;

    public string TextInfo
    {
        get
        {
            return textInfo;
        }
    }
}
