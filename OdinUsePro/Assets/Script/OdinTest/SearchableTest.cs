using Sirenix.OdinInspector;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchableTest : MonoBehaviour
{
    [Searchable]
    public List<SearchItem> ItemList;

    [Serializable]
    public class SearchItem
    {
        public string Id;
        public string Name;
        public int Age;
    }

}
