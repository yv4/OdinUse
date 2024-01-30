using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInInspectorTest : MonoBehaviour
{
    [ShowInInspector]
    public int DisableProp1 { get; }

    [ShowInInspector,EnableGUI]
    public int DisableProp2 { get; }

    [ShowInInspector,EnableGUI]
    public int DisableProp3 { get; set; }
}
