using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildGameObjetsOnlyTest : MonoBehaviour
{
    [ChildGameObjectsOnly]
    public GameObject child;
}
