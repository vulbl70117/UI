using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 基底類別
public abstract class Pokemon13:MonoBehaviour
{
    public string _name;
    
    public int hp = 15;
    public virtual int atk()
    { return 0; }
    public virtual int def()
    { return 0; }
    public void Demage(int a)
    {
        hp -= a;
        if (hp <= 0)
        {
            hp=0;
        }
    }
}

