using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIColorTest : MonoBehaviour
{
    [GUIColor(.5f,1,0,1)]
    public int Health;

    [GUIColor(0,.5f,1f,1)]
    public int Power;

    [GUIColor(1,.5f,0,1)]
    public int Attack;
}
