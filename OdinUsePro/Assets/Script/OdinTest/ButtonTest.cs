using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour
{
    public int Value = 1;

    [Button("�ı�ֵ",ButtonSizes.Large)]
    public void ShowName()
    {
        Value++;
    }
}
