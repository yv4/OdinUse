using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabGroupTest : MonoBehaviour
{
    [TabGroup("BaseInfo")]
    public string studentName;
    [TabGroup("BaseInfo")]
    public string studentAge;
    [TabGroup("BaseInfo")]
    public string studentSex;

    [TabGroup("Score")]
    public string EnglishScore;
    [TabGroup("Score")]
    public string MathScore;
    [TabGroup("Score")]
    public string ArtScore;
}
