using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollectionChangedTest : MonoBehaviour
{
    public int count = 0;
    [OnCollectionChanged("ShowListCount")]
    public List<string> nameList;

    private void ShowListCount()
    {
        count = nameList.Count;
    }
}
