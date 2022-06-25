using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = "‰ğô”F" + ScoreManager.Get((int)ScoreManager.ScoreName.SN_Score).ToString();

    }
}
