using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CautionSceneManager : MonoBehaviour
{
    private Image fadePanel;  //�t�F�[�h�pUI
    private float fadeAlpha;  //�t�F�[�h�l
    private bool isFadeIn;  //�t�F�[�h�t���O
    private bool isFadeOut;  //�t�F�[�h�t���O
    private float stopTime = 0.0f;  //��~�p�ϐ�

    public float FadeSpeed = 1.0f;  //�t�F�[�h���x
    public float DisplayTime = 3.0f;  //�\������


    // Start is called before the first frame update
    void Start()
    {
        fadePanel = GameObject.Find("FadePanel").GetComponent<Image>();  //�t�F�[�h�p�p�l�����擾

        fadeAlpha = 1.0f;
        isFadeIn = true;
        isFadeOut = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn)
        {
            fadeAlpha -= FadeSpeed * Time.deltaTime;  //�t�F�[�h�l��ύX
            fadePanel.color = new Color(0, 0, 0, fadeAlpha);  //�t�F�[�h�l�𔽉f

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
            fadeAlpha += FadeSpeed * Time.deltaTime;  //�t�F�[�h�l��ύX
            fadePanel.color = new Color(0, 0, 0, fadeAlpha);  //�t�F�[�h�l�𔽉f

            if (fadeAlpha >= 1.0f)
            {
                fadeAlpha = 1.0f;
                isFadeOut = false;
                SceneChange();  //�V�[�����ړ�
            }
        }
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("TitleScene");  //�V�[�����ړ�
    }
}
