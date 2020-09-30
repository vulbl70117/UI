using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound_slider : MonoBehaviour
{
    public Slider slider = null;
    public background_music audioMgr;
    // Start is called before the first frame update
    void Start()
    {
        //取slider初始值
        slider.value = audioMgr.getvol();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void close_audioMgr()
    {
        
    }
}
