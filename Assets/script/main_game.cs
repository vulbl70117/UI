using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class main_game : MonoBehaviour
{
    public Pokemon13 p1;
    public Pokemon13 p2;
    public pnl_r1 panel1;
    public pnl_r1 panel2;
    public Text message;
    private float timer = 0.0f;
    //
    public static System.Random rand = new System.Random();
    public static System.Random rand2 = new System.Random();
    //
    private Pokemon13 Winer = null;
    private Pokemon13 Loser = null;
    // Start is called before the first frame update
    void Start()
    {
        panel1.init(p1.name, p1.hp, p1.hp);
        panel2.init(p2.name, p2.hp, p2.hp);
        string mag = "PK!!!";
        message.text = mag;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && timer > 1 && Winer == null)
        {
            Next();
            timer = 0;
        }
        timer += Time.deltaTime;
    }
    public void Next()
    {
        //p1 = new Pikachu13(); // Pikachu13 Bulbasaur13 Squirtle13
        //p2 = new Bulbasaur13();
        
        Debug.Log(p1._name + " 有HP: " + p1.hp);
        Debug.Log(p2._name + " 有HP: " + p2.hp);
       
            
           
        Pokemon13 pAtker = null;
        Pokemon13 pDefer = null;
        string mag = " ";
        int bWho = Random.Range(0, 2);
        if (bWho > 0)
        {
            pAtker = p1;
            pDefer = p2;
        }
        else
        {
            pAtker = p2;
            pDefer = p1;
        }
        Debug.Log(pAtker._name + " 攻擊");
        mag += pAtker._name + " 攻擊";
        message.text = mag;
        int damage = pAtker.atk() - pDefer.def();
        if (damage <= 0)
        {
            //Debug.Log(pDefer.name + " 成功防禦");
        }
        else
        {
            //Debug.Log(pAtker.name + " 攻擊成功, " + pDefer.name + " 損傷 " + damage);
            pDefer.hp -= damage;
        }
        Debug.Log(pDefer._name + " 還有HP: " + pDefer.hp);
        mag += pDefer._name + " 還有HP: " + pDefer.hp+"\n";
        message.text = mag;
        if (pDefer.hp <= 0)
        {
            Winer = pAtker;
            Loser = pDefer;
            Debug.Log(pDefer._name + " 被打趴了..");
            Debug.Log("獲勝者為 " + pAtker._name);
            mag += pDefer._name + " 被打趴了.." + "\n";
            mag += "獲勝者為 " + pAtker._name + "\n";
            message.text = mag;

            return;
        }
        
       
    }
}
