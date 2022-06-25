using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class result : MonoBehaviour
{

    [SerializeField] private Text time;
    [SerializeField] private Text score;
    [SerializeField] private Text isClear;



    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.Reset();
        if(ScoreManager.GetIsClear() == true)
        {
            isClear.text = "GameClear";
        }
        if(ScoreManager.GetIsClear() == false)
        {
            isClear.text = "GameOver";
        }
        time.text = ScoreManager.Get((int)ScoreManager.ScoreName.SN_Time).ToString();
        score.text = ScoreManager.Get((int)ScoreManager.ScoreName.SN_Score).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
