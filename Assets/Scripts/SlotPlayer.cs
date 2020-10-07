using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SlotPlayer : MonoBehaviour
{
    public string PokeName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChooseMe()
    {
        Toggle tg = this.GetComponent<Toggle>();
        if (tg.isOn)
        {
            CentralData.GetInst().Player = PokeName;
            Debug.Log(CentralData.GetInst().Player);
        }
    }

    public void ChooseEnemy()
    {
        CentralData.GetInst().Enemy = PokeName;
        Debug.Log(CentralData.GetInst().Enemy);
        SceneManager.LoadScene("Game");
    }
}
