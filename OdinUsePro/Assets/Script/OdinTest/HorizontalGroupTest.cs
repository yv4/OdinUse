using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalGroupTest : MonoBehaviour
{
    [HorizontalGroup("BaseInfo"),HideLabel]
    public string studentName;
    [HorizontalGroup("BaseInfo"),HideLabel]
    public string studentAge;
    [HorizontalGroup("BaseInfo"), HideLabel]
    public string studentSex;


}
