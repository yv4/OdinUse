using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnValueChangedTest : MonoBehaviour
{
    [OnValueChanged("ChangeCount")]
    public bool OnStateChange;
    public int count = 0;
    private void ChangeCount()
    {
        count++;
    }
}
