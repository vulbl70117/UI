using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// 1005 今天做了甚麼？
// 1. 動態設定p1 p2
// 1.1 建立一個寶可夢工廠
// 1.2 腳色物件的設定與工廠變數
// 1.2 設計Create()
// 1.3 RoleFactory整合至MainGame
// 2. 初始
public class MainGame : MonoBehaviour
{
    // 角色
    public Pokemon13 p1;
    public Pokemon13 p2;
    // 角色資訊框
    public PnlRoleInfo panel1;
    public PnlRoleInfo panel2;
    // 對話框
    public Text message;
    // 系統變數
    private float timer = 0.0f;
    // 亂數
    public static System.Random rand = new System.Random();
    public static System.Random rand2 = new System.Random();
    // 判斷勝負
    private Pokemon13 pWinner = null;
    private Pokemon13 pLoser = null;
    // 工廠變數
    public RoleFactory factory = null;
    // Start is called before the first frame update
    void Start()
    {
        //  呼叫CentralData
        CentralData myData = CentralData.GetInst();

        // 動態設定p1 p2
        //p1 = factory.Create("黃色小鴨");
        //p2 = factory.Create("黃色小鴨");
        p1 = factory.Create(myData.Player);
        p2 = factory.Create(myData.Enemy);

        p1.transform.position = new Vector3(-5.0f,-0.7f,0.0f);
        p2.transform.position = new Vector3(5.2f, 1.0f, 0.0f);

        // 翻轉p1
        SpriteRenderer spr = p1.GetComponent<SpriteRenderer>();
        if (spr != null) spr.flipX = true;

        // 顯示腳色
        p1.gameObject.SetActive(true);
        p2.gameObject.SetActive(true);

        // 初始化腳色的訊息框
        panel1.Init(p1);
        panel2.Init(p2);

        string msg = "開戰!! " + p1.pokename + " vs " + p2.pokename + " 決鬥開始";
        message.text = msg;
    }

    // Update is called once per frame
    void Update()
    {
        // 當滑鼠click時 且 相隔要一秒以上才可以再進來
        if (Input.GetMouseButtonDown(0) && timer > 1.0f && pWinner==null)
        {
            //Debug.Log(timer);
            Next();
            timer = 0.0f; 
        }
        timer += Time.deltaTime; 
    }

    public void Next() // 做每回合
    {
        //round++;
        //Debug.Log("第" + round + "回合");
        Pokemon13 pAtker = null;
        Pokemon13 pDefer = null;
        string msg = "";  // 1.
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
        Debug.Log(pAtker.pokename + " 攻擊");
        msg += pAtker.pokename + " 攻擊\n";
        message.text = msg;

        int damage = pAtker.Atk() - pDefer.Def();
        if (damage <= 0)
        {
            //Debug.Log(pDefer.name + " 成功防禦");
            msg += pDefer.pokename + " 成功防禦\n";
            message.text = msg;
        }
        else
        {
            //Debug.Log(pAtker.name + " 攻擊成功, " + pDefer.name + " 損傷 " + damage);
            msg += pAtker.pokename + " 攻擊成功, " + pDefer.pokename + " 損傷 " + damage + "\n";
            message.text = msg;

            //pDefer.hp -= damage;
            pDefer.Damage(damage);
        }
        Debug.Log(pDefer.pokename + " 還有HP: " + pDefer.hp);
        msg += pDefer.pokename + " 還有HP: " + pDefer.hp + "\n";
        message.text = msg;

        if (pDefer.hp <= 0)
        {
            // 勝負已出!!
            pWinner = pAtker; // 勝者
            pLoser = pDefer; // 魯蛇

            Debug.Log(pDefer.pokename + " 被打趴了..");
            Debug.Log("獲勝者為 " + pAtker.pokename);
            msg += pDefer.pokename + " 被打趴了.." + "\n";
            msg += "獲勝者為 " + pAtker.pokename + "\n";
            message.text = msg;
            //bPlay = false;
        }
    }
}
