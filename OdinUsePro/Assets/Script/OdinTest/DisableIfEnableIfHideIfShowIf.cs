using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableIfEnableIfHideIfShowIf : MonoBehaviour
{
    public bool AAA;
    [DisableIf("AAA")]
    public string DisableWenA;
    [EnableIf("AAA")]
    public string EnableWenA;
    [HideIf("AAA")]
    public string HideWenA;
    [ShowIf("AAA")]
    public string ShowWenA;

    public enum SubjectType {Math,English,Arts }
    public SubjectType sType;
    
    [ShowIf("sType",SubjectType.Math)]
    public int mathScore;

    [ShowIf("sType", SubjectType.English)]
    public int EnglishScore;

    [ShowIf("sType", SubjectType.Arts)]
    public int ArtsScore;

    [EnableIf("@1==2")]
    public string Show1;

    [EnableIf("Show2Method")]
    public string Show2;

    private bool Show2Method()
    {
        return false;
    }

}
