using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertySpaceTest : MonoBehaviour
{
    public string TypeA1, TypeA2, TypeA3;
    [PropertySpace]
    public string TypeB1;
    public string TypeB2;
    public string TypeB3;
}
