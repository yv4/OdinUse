using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGroupTest : MonoBehaviour
{
    [ToggleGroup("BaseInfo")]
    public bool BaseInfo;

    [ToggleGroup("BaseInfo")]
    public string studentName;
    [ToggleGroup("BaseInfo")]
    public string studentAge;
    [ToggleGroup("BaseInfo")]
    public string studentSex;

    [ToggleGroup("Score")]
    public bool Score;
    [ToggleGroup("Score")]
    public string EnglishScore;
    [ToggleGroup("Score")]
    public string MathScore;
    [ToggleGroup("Score")]
    public string ArtScore;
}
