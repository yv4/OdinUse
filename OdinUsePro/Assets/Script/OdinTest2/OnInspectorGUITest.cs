using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInspectorGUITest : MonoBehaviour
{
    [OnInspectorGUI("ChangeCount")]
    public int count = 0;

    private void ChangeCount()
    {
        count++;
    }
}
