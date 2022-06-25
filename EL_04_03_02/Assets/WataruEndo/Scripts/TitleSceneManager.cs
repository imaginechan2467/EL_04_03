using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleSceneManager : MonoBehaviour
{
    private AudioSource audioSource;  //AudioSource
    public AudioClip SE_suzu;  //����

    private Image fadePanel;  //�t�F�[�h�pUI
    private float fadeAlpha;  //�t�F�[�h�l
    private bool isFadeIn;  //�t�F�[�h�t���O
    private bool isFadeOut;  //�t�F�[�h�t���O
    private bool isFade;  //�t�F�[�h�t���O

    public float FadeSpeed = 1.0f;  //�t�F�[�h���x


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();  //AudioSource���擾
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

        //�X�y�[�X�L�[�ŃQ�[���V�[����
        if (Input.GetKeyDown(KeyCode.Space) && !isFadeOut)
        {
            audioSource.PlayOneShot(SE_suzu);  //����炷
            isFadeOut = true;
        }

        if (isFadeOut)
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
        SceneManager.LoadScene("GameScene");  //�V�[�����ړ�
    }
}
