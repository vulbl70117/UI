using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cetag
{
    public static Cetag mi=null;
    public static Cetag In()
    {
        if (mi==null)
        {
            mi = new Cetag();
        }
        return mi;
    }
    public float at;
    private Cetag()
    {

    }
}
