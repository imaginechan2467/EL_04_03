using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScoreManager
{
    public enum ScoreName
    {
        SN_Time,
        SN_Score,
        SN_MAX
    }

    static int[] score = new int[(int)ScoreName.SN_MAX];
    // リセット
    public static void Reset()
    {
        for (int i = 0; i < score.Length; i++)
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
