using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CentralData
{
    // singleton作法
    // 1. private 建構子
    // 2. 靜態成員與GetInstance方法
    private static CentralData mInstance = null;
    // 取得存檔的路徑與檔名
    private static string path = Application.dataPath + "/playerdata/";
    private static string filename = "record.json";
    public static CentralData GetInst()
    {
        if (mInstance == null)
        {
            if (File.Exists(path + filename))
            {
                mInstance = LoadData();
            }
            else
            {
                mInstance = new CentralData();
            }
        }
        return mInstance;
    }

    public static void SaveData()
    {
        CentralData data = GetInst();
        // CentralData 轉 Json
        string jstr = JsonUtility.ToJson(data);
        // 寫檔
        if (!Directory.Exists(path)) // 不存在
        {
            // 建立新的資料夾
            Directory.CreateDirectory(path);
        }
        File.WriteAllText(path + filename, jstr);
    }

    public static CentralData LoadData()
    {
        // 讀檔
        string jstr = File.ReadAllText(path + filename);
        // json轉物件
        CentralData data = JsonUtility.FromJson<CentralData>(jstr);
        return data;
    }

    //==========================================
    // 成員變數們
    public float AudioVol = 1.0f; // 音量(0~1)
    public string Player = "鐵公雞";
    public string Enemy = "粉紅兔";
    // 建構子
    private CentralData()
    {
    }
    // 方法們
}
