using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 基底類別
public abstract class Pokemon13 : MonoBehaviour
{
    public string pokename;
    public int hp = 15;
    public abstract int Atk();
    public abstract int Def();

    public void Damage(int d)
    {
        hp -= d;
        if (hp < 0) hp = 0;
        // 執行被打的動作
        Animator a = GetComponent<Animator>();
        if (a != null) a.SetTrigger("hit");
    }
}
