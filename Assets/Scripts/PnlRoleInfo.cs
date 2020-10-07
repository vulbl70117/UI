using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PnlRoleInfo : MonoBehaviour
{
    public Text Name;
    public Text CurHP;
    public Text MaxHP;
    public Slider BarHP;

    private Pokemon13 role; //1

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (role != null)
        {
            CurHP.text = role.hp.ToString();
            SetSliderHP(); // 2.
        }
    }

    // 2
    public void Init(Pokemon13 r)
    {
        this.role = r;
        Init(r.pokename, r.hp, r.hp);
    }

    public void Init(string name, int curhp, int maxhp)
    {
        Name.text = name;
        CurHP.text = curhp.ToString();
        MaxHP.text = maxhp.ToString();
        BarHP.value = (float)curhp/(float)maxhp;
    }

    // 1.
    public void SetSliderHP()
    {
        float fcur = (float)Int32.Parse(CurHP.text);
        float fmax = (float)Int32.Parse(MaxHP.text);
        BarHP.value = fcur / fmax;
    }
}
