using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralDataViewer : MonoBehaviour
{
    public float AudioVol
    {
        get
        {
            return CentralData.GetInst().AudioVol;
        }
    }

    public string Player
    {
        get
        {
            return CentralData.GetInst().Player;
        }
    }

    public string Enemy
    {
        get
        {
            return CentralData.GetInst().Enemy;
        }
    }

}
