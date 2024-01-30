using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyRangeTest : MonoBehaviour
{
   [ShowInInspector,PropertyRange(0,1)]
   public float Progress { get; set;}
}
