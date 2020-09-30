using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RGB : MonoBehaviour
{
    public Button[] list;
    public int Curpos;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouse = Input.GetAxis("Mouse ScrollWheel");
        if (mouse > 0.0f)
        {
            if (Curpos < list.Length - 1)
            {
                Curpos++;
                SetPos();
            }
        }
        else if (mouse < 0.0f)
        {
            if (Curpos > 0)
            {
                Curpos--;
                SetPos();
            }
        }
        if (Input.GetMouseButton(1))
        {
            Button b = list[Curpos];
            Text t = b.GetComponent<Text>();
        }
    }
    public void SetPos()
    {
        for (int i = 0; i < list.Length; i++)
        {
            if (i == Curpos)
            {
                list[i].enabled = true;
            }
            else
            {
                list[i].enabled = false;
            }
        }
    }
}
