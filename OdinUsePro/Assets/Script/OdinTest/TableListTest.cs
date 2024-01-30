using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableListTest : MonoBehaviour
{
    [TableList]
    public List<Student> StudentList = new List<Student>();

    [TableList,TableColumnWidth(20,Resizable =false)]
    [Serializable]
    public class Student
    {
        public string Name;
        public int Id;
        public float Score;
    }


}
