using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleTest : MonoBehaviour
{
    [Title("基础属性")]
    public string Health;
    public string Attack;
    public string Power;

    [Title("特有属性")]
    public float MoveSpeed;
}
