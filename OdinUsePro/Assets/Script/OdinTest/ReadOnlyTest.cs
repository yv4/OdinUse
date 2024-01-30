using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadOnlyTest : MonoBehaviour
{
    [ReadOnly]
    public string Player1Name = "KDF";
    public string Player2Name = "KKK";
}
