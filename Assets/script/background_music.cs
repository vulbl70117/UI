using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class background_music : MonoBehaviour
{
    public AudioSource sourse = null;
    public Slider peko=null;
    // Start is called before the first frame update
    void Start()
    {
        sourse.volume = Cetag.In().at;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void aaa()
    {
        sourse.volume = peko.value;
    }

    public float getvol()
    {
        return sourse.volume;
    }
    public void setvol(float vol)
    {
        Cetag.In().at = vol;
        peko.value = vol;
    }
}
