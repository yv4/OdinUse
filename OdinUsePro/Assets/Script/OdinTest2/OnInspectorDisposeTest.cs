using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnInspectorDisposeTest : MonoBehaviour
{
    [OnInspectorDispose("ChangeCount")]
    public int count = 0;

    private void ChangeCount()
    {
        count++;
    }
}
