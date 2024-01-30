using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertyOrderTest : MonoBehaviour
{
    [PropertyOrder(2)]
    public string player2Name;
    [PropertyOrder(1)]
    public string player1Name;
}
