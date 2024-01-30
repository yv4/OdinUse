using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryDrawerSettingsTest : SerializedMonoBehaviour
{
    [DictionaryDrawerSettings]
    public Dictionary<string, float> StudentDict = new Dictionary<string, float>();
}
