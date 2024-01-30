using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomContextMenuTest : MonoBehaviour
{
    [CustomContextMenu("SetAgeTen", "SetValueAsTen")]
    public int Age;
    
    public void SetValueAsTen()
    {
        Age = 10;
    }
}
