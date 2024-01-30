using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrapTest : MonoBehaviour
{
    [Wrap(0,10)]
    public int Score;
}
