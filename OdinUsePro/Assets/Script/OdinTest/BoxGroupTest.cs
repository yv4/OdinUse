using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGroupTest : MonoBehaviour
{
    [BoxGroup("BaseInfo",CenterLabel = true)]
    public string studentName;
    [BoxGroup("BaseInfo", CenterLabel = true)]
    public string studentAge;
    [BoxGroup("BaseInfo", CenterLabel = true)]
    public string studentSex;

    [BoxGroup("Score", CenterLabel = true)]
    public string EnglishScore;
    [BoxGroup("Score", CenterLabel = true)]
    public string MathScore;
    [BoxGroup("Score", CenterLabel = true)]
    public string ArtScore;

}
