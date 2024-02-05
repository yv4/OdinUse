using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OdinWindowTest : OdinEditorWindow
{
    [MenuItem("Tools/OdinWindowTest")]
    public static void ShowWindow()
    {
        var window = GetWindow<OdinWindowTest>();
        window.Show();
    }

    [LabelText("学生姓名")]
    public string StudentName;
    [LabelText("英文成绩")]
    public float EnglishScore;
    [LabelText("数学成绩")]
    public float MathScore;
    [LabelText("美术成绩")]
    public float ArtScore;
    [ReadOnly, LabelText("总成绩")] public float TotalScore;

    [Button("计算总成绩",ButtonSizes.Large,Style =ButtonStyle.Box)]
    public void GetTotalScore()
    {
        TotalScore = EnglishScore + MathScore + ArtScore;
    }

}
