using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndentTestTest : MonoBehaviour
{
    [Indent] public int A;
    [Indent(2)] public int B;
    [Indent(-1)] public int C;
}
