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
    // ���Z�b�g
    public static void Reset()
    {
        for (int i = 0; i < score.Length; i++)
        {
            score[i] = 0;
        }
    }
    // �X�R�A�ǉ������_
    public static void Add(int added, int name)
    {
        score[name] += added;
        if (score[name] < 0) { score[name] = 0; }
    }
    // �X�R�A�擾
    public static int Get(int name)
    {
        return score[name];
    }
}
