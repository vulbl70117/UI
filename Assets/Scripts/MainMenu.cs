using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SaveData()
    {
        // 進行對CentralData存檔
        Debug.Log("進行對CentralData存檔");
        CentralData.SaveData();
    }
}
