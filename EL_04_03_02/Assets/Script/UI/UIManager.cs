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
      //  ScoreText.text = "�������F" + ScoreManager.Get((int)ScoreManager.ScoreName.SN_Score).ToString();


 
        if (ScoreManager.Get((int)ScoreManager.ScoreName.SN_ClearType) == 0)
        {
            MoveText.text= "�ڕW�F\n���ꂽ�m�l�`�ɂ���ꂽ�����̊��T���I�I";
        }
         if (ScoreManager.Get((int)ScoreManager.ScoreName.SN_ClearType) == 1)
        {
            
                MoveText.text = "�ڕW�F\n�G�Ɍ����炸�ɒE�o����I�I";

        }
    }
}
