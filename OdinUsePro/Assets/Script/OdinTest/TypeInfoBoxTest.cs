using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypeInfoBoxTest : MonoBehaviour
{
    [HideLabel]
    public Student st;

    [Serializable,TypeInfoBox("ѧ��������Ϣ")]
    public class Student
    {
        public string Name;
        public int Score;
    }
}
