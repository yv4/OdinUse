using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumToggleButtonTest : MonoBehaviour
{
    [EnumToggleButtons]
    public SubjectType st;
    public enum SubjectType { English,Math,Arts}
}
