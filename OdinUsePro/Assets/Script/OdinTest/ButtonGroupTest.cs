using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGroupTest : MonoBehaviour
{
    [Button("Show1"),ButtonGroup]
    public void ShowValue1(){
        Debug.Log("Show1");
    }

    [Button("Show2"), ButtonGroup]
    public void ShowValue2() {
        Debug.Log("Show2");
    }

    [Button("Show3"), ButtonGroup]
    public void ShowValue3() {
        Debug.Log("Show3");
    }
}
