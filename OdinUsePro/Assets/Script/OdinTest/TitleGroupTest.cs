using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleGroupTest : MonoBehaviour
{
    [TitleGroup("BaseInfo")]
    public string studentName;
    [TitleGroup("BaseInfo")]
    public string studentAge;
    [TitleGroup("BaseInfo")]
    public string studentSex;

    [TitleGroup("Score")]
    public string EnglishScore;
    [TitleGroup("Score")]
    public string MathScore;
    [TitleGroup("Score")]
    public string ArtScore;
}
