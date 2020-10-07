﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMgr : MonoBehaviour
{
    public AudioSource source = null;
    // Start is called before the first frame update
    void Start()
    {
        //source = this.GetComponent<AudioSource>();

        // 初始
        source.volume = CentralData.GetInst().AudioVol;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetVol()
    {
        if (CentralData.GetInst().AudioVol != source.volume)
            source.volume = CentralData.GetInst().AudioVol;
        return source.volume;
    }

    public void SetVol(float v)
    {
        CentralData.GetInst().AudioVol = v;
        source.volume = v;
    }
}
