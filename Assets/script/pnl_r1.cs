using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pnl_r1 : MonoBehaviour
{
    public Text Name;
    public Text curHP;
    public Text maxHP;
    public Slider barHP;
    private Pokemon13 role;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (role)
        {
            curHP.text = role.hp.ToString();
        }
    }
    public void init(Pokemon13 r)
    {
        role = r;
        init(r._name, r.hp, r.hp);
    }
    public void init(string name, int curhp, int maxhp)
    {
        Name.text = name;
        curHP.text = curhp.ToString();
        maxHP.text = maxhp.ToString();
        barHP.value = (float)curhp / (float)maxhp;
    }
    public void SetSliderHP()
    {
        float fcur = (float)Int32.Parse(curHP.text);
        float fmax = (float)Int32.Parse(maxHP.text);
        barHP.value = fcur / fmax;
    }
}
