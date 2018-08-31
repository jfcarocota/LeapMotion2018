using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerController : MonoBehaviour
{
    [SerializeField]
    List<Transform> fingersBones;

    [SerializeField, Tooltip("La punta del dedo")]
    Transform tip;

    public List<Transform> FingersBones
    {
        get
        {
            return fingersBones;
        }
    }

    /// <summary>
    /// Esto es la punta del dedo, es un transform
    /// </summary>
    public Transform Tip
    {
        get
        {
            return tip;
        }
    }
}
