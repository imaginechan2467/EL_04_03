using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class ScoreManager
{
    static int score = 0;

    // ���Z�b�g
    public static void Reset()
    {
        score = 0;
    }
    // �X�R�A�ǉ������_
    public static void Add(int added)
    {
        score += added;
        if (score < 0) { score = 0; }
    }
    // �X�R�A�擾
    public static int Get()
    {
        return score;
    }
}
