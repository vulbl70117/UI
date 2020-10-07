using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListSkills2 : MonoBehaviour
{
    public Button[] list;
    public int CurIdx = 0;
    // Start is called before the first frame update
    void Start()
    {
        SetPos();
    }

    // Update is called once per frame
    void Update()
    {
        // 抓滾輪滾滾滾的效果
        float move = Input.GetAxis("Mouse ScrollWheel");
        //if(move != 0.0f) Debug.Log(move);
        if (move > 0.0f)
        {
            if(CurIdx<list.Length-1) CurIdx++;
            SetPos();
        }
        else if (move < 0.0f)
        {
            if(CurIdx>0) CurIdx--;
            SetPos();
        }
        // 滑鼠右鍵的效果
        if (Input.GetMouseButtonDown(1)) //0:左, 1:右
        {
            Button b = list[CurIdx];
            Text t = b.GetComponentInChildren<Text>(); //元件
            Debug.Log(t.text); // 元件中的text屬性
        }
    }

    public void SetPos()
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (i == CurIdx)
                list[i].enabled = true;
            else
                list[i].enabled = false;
        }
    }
}
