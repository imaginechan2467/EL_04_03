using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text MoveText;

    void Start()
    {
        ScoreManager.Reset();
    }

    // Update is called once per frame
    void Update()
    {
      //  ScoreText.text = "解呪数：" + ScoreManager.Get((int)ScoreManager.ScoreName.SN_Score).ToString();


 
        if (ScoreManager.Get((int)ScoreManager.ScoreName.SN_ClearType) == 0)
        {
            MoveText.text= "目標：\n呪われた藁人形につけられた自分の顔を探せ！！";
        }
         if (ScoreManager.Get((int)ScoreManager.ScoreName.SN_ClearType) == 1)
        {
            
                MoveText.text = "目標：\n敵に見つからずに脱出せよ！！";

        }
    }
}
