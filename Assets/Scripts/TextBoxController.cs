using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBoxController : MonoBehaviour
{

    Text info;

    [SerializeField]
    GameObject panel;

    private void Awake()
    {
        info = GetComponent<Text>();
        info.text = "";
    }

    public string SetInfo
    {
        set
        {
            info.text = value;
        }
    }

    public bool IsActive
    {
        get
        {
            return panel.activeSelf;
        }
        set
        {
            panel.SetActive(value);
        }
    }
}
