using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    TextBoxController textBoxController;

    private void Awake()
    {
        instance = this;
    }

    public string SetInfo
    {
        set
        {
            textBoxController.SetInfo = value;
        }
    }

    public bool IsActive
    {
        get
        {
            return textBoxController.IsActive;
        }
        set
        {
            textBoxController.IsActive = value;
        }
    }
}
