using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumPagingTest : MonoBehaviour
{
    [EnumPaging]
    public SubjectType st;

    public enum SubjectType
    {
        English,
        Math,
        Arts
    }

}
