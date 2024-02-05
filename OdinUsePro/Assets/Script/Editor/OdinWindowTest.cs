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

    [LabelText("ѧ������")]
    public string StudentName;
    [LabelText("Ӣ�ĳɼ�")]
    public float EnglishScore;
    [LabelText("��ѧ�ɼ�")]
    public float MathScore;
    [LabelText("�����ɼ�")]
    public float ArtScore;
    [ReadOnly, LabelText("�ܳɼ�")] public float TotalScore;

    [Button("�����ܳɼ�",ButtonSizes.Large,Style =ButtonStyle.Box)]
    public void GetTotalScore()
    {
        TotalScore = EnglishScore + MathScore + ArtScore;
    }

}
