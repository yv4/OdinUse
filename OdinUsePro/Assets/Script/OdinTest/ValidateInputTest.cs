using Sirenix.OdinInspector;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidateInputTest : MonoBehaviour
{
    [ValidateInput("CheckPlayerAge","",InfoMessageType.Error)]
    public int PlayerAge;

    public bool CheckPlayerAge(int age,ref string errorMesage,ref InfoMessageType?messageType)
    {
        errorMesage = "½ÇÉ«Î´³ÉÄê";
        return age >= 15;
    }
}
