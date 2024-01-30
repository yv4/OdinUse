using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedPropertyTest : MonoBehaviour
{
    [Delayed]
    [OnValueChanged("OnValueChanged")]
    public int DelayedField;

    private void OnValueChanged()
    {
        Debug.Log("Value Changed");
    }
}
