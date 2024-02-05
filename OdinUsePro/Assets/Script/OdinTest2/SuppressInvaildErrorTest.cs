using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppressInvaildErrorTest : MonoBehaviour
{
    [Range(0,10),SuppressInvalidAttributeError]
    public string MyScore1;

    [Range(0,10)]
    public string MyScore2;
}
