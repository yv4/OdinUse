using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoBoxTest : MonoBehaviour
{
    [InfoBox("abcdefg\nhijklmn")]
    public int MyMathScore;
}
