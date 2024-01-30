using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InlineProertyTest : MonoBehaviour
{
    [InlineProperty]
    public MyV3 myInLine;
    public MyV3 mv;

    [Serializable]
    public class MyV3
    {
        [HorizontalGroup(LabelWidth =10)]
        public int x, y, z;
    }
}
