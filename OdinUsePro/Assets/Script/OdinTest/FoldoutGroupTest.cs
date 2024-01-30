using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoldoutGroupTest : MonoBehaviour
{
    [FoldoutGroup("BaseInfo")]
    public string studentName;
    [FoldoutGroup("BaseInfo")]
    public string studentAge;
    [FoldoutGroup("BaseInfo")]
    public string studentSex;

    [FoldoutGroup("Score")]
    public string EnglishScore;
    [FoldoutGroup("Score")]
    public string MathScore;
    [FoldoutGroup("Score")]
    public string ArtScore;

}
