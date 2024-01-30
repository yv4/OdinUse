using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InlineButtonTest : MonoBehaviour
{
    [InlineButton("Reset")]
    public StudentScore ss;
    public void Reset()
    {
        Debug.Log("Test");
    }

    [Serializable]
    public class StudentScore
    {
        public float match = 100;
        public float english = 50;
    }
}
