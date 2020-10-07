using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ListSkills : MonoBehaviour
{
    public int CurPos = 0;
    public Button[] list;
    // Start is called before the first frame update
    void Start()
    {
        SetPos();
    }

    // Update is called once per frame
    void Update()
    {
        // 抓滑鼠滾輪的效果
        float move = Input.GetAxis("Mouse ScrollWheel");
        if (move > 0.0f)
        {
            if (CurPos < list.Length - 1) CurPos++;
            SetPos();
        }
        else if (move < 0.0f)
        {
            if (CurPos > 0) CurPos--;
            SetPos();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (list.Length > 0)
            {
                Text t = list[CurPos].GetComponentInChildren<Text>();
                Debug.Log(t.text);
            }
        }
    }

    void SetPos()
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (i == CurPos)
                list[i].enabled = true;
            else
                list[i].enabled = false;
        }
    }
}
