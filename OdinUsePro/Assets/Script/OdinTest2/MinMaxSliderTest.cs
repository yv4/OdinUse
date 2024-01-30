using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMaxSliderTest : MonoBehaviour
{
    [MinMaxSlider(0,18)]
    public Vector2Int girlAgeRange;
}
