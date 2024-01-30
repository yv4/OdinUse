using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTest : MonoBehaviour
{
    public MyToggle t1, t2;

    [Serializable,Toggle("Enable")]
    public class MyToggle
    {
        public bool Enable;
        public string Name;
        public string Age;
    }
}
