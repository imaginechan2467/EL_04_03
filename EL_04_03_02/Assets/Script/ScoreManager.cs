using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class ScoreManager
{

    public enum ScoreName
    {
        SN_Time,
        SN_Score,
        SN_ClearType,//0=張り替える1=脱出2=クリア-1=ゲームオーバー
        SN_MAX
    }

    private static float time;

    public static void Start()
    {
        time = 0.0f;
        Reset();
    }

    public static void Update()
    {
        time += Time.deltaTime;
        score[(int)ScoreName.SN_Time] = (int)time;
    }

    static int[] score = new int[(int)ScoreName.SN_MAX];
    // リセット
    public static void Reset()
    {
        for (int i = 0; i < (int)ScoreName.SN_MAX; i++)
        {
            score[i] = 0;
        }
    }
    // スコア追加か減点
    public static void Add(int added, int name)
    {
        score[name] += added;
        if (score[name] < 0) { score[name] = 0; }
    }
    // スコア取得
    public static int Get(int name)
    {
        return score[name];
    }
}
