using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableColumnWidthTest : MonoBehaviour
{
    [TableList]
    public List<Student> studentlist = new List<Student>();

    [Serializable]
    public class Student
    {
        [TableColumnWidth(50, Resizable = false)]
        public string name;
        public int id;
        public float score;
    }
}
