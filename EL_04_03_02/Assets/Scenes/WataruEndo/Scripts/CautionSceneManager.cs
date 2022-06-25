using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CautionSceneManager : MonoBehaviour
{
    private Image fadePanel;  //フェード用UI
    private float fadeAlpha;  //フェード値
    private bool isFadeIn;  //フェードフラグ
    private bool isFadeOut;  //フェードフラグ
    private float stopTime = 0.0f;  //停止用変数

    public float FadeSpeed = 1.0f;  //フェード速度
    public float DisplayTime = 3.0f;  //表示時間


    // Start is called before the first frame update
    void Start()
    {
        fadePanel = GameObject.Find("FadePanel").GetComponent<Image>();  //フェード用パネルを取得

        fadeAlpha = 1.0f;
        isFadeIn = true;
        isFadeOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn)
        {
            fadeAlpha -= FadeSpeed * Time.deltaTime;  //フェード値を変更
            fadePanel.color = new Color(0, 0, 0, fadeAlpha);  //フェード値を反映

            if (fadeAlpha <= 0.0f)
            {
                fadeAlpha = 0.0f;
                isFadeIn = false;
            }
        }

        if(!isFadeIn)
        {
            stopTime += Time.deltaTime;

            if(stopTime >= DisplayTime)
            {
                isFadeOut = true;
            }
        }

        if(isFadeOut)
        {
            fadeAlpha += FadeSpeed * Time.deltaTime;  //フェード値を変更
            fadePanel.color = new Color(0, 0, 0, fadeAlpha);  //フェード値を反映

            if (fadeAlpha >= 1.0f)
            {
                fadeAlpha = 1.0f;
                isFadeOut = false;
                SceneChange();  //シーンを移動
            }
        }
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("TitleScene");  //シーンを移動
    }
}
