using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class result : MonoBehaviour
{

    [SerializeField] private Text time;
    [SerializeField] private Text score;
    [SerializeField] private Text isClear;

    private void Start()
    {
        if (ScoreManager.Get((int)ScoreManager.ScoreName.SN_ClearType) == 2)
        {
            isClear.text = "GameClear";
            CalcScore();
        }
        if(ScoreManager.Get((int)ScoreManager.ScoreName.SN_ClearType) == -1)
        {
            isClear.text = "GameOver";
        }
        time.text = "Time : " + ScoreManager.Get((int)ScoreManager.ScoreName.SN_Time).ToString();
        score.text = "Score : " + ScoreManager.Get((int)ScoreManager.ScoreName.SN_Score).ToString();
    }

    private void CalcScore()
    {
        int time = ScoreManager.Get((int)ScoreManager.ScoreName.SN_Time);
        if(time == 120)
        {
            ScoreManager.Add(500, (int)ScoreManager.ScoreName.SN_Score);
        }
        else if(time == 240)
        {
            ScoreManager.Add(250, (int)ScoreManager.ScoreName.SN_Score);
        }
        else if (time == 360)
        {
            ScoreManager.Add(100, (int)ScoreManager.ScoreName.SN_Score);
        }
        else if (time == 480)
        {
            ScoreManager.Add(50, (int)ScoreManager.ScoreName.SN_Score);
        }
        else if (time == 600)
        {
            ScoreManager.Add(1, (int)ScoreManager.ScoreName.SN_Score);
        }
    }
}
