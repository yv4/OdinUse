using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueDropDownTest : MonoBehaviour
{
    [ValueDropdown("PlayerLevel")]
    public List<int> PlayerLevel = new List<int>() { 1,2,3,4};
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
