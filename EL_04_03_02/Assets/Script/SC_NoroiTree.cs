using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SC_NoroiTree : MonoBehaviour
{
    [SerializeField] Sprite[] picList = null;
    [SerializeField] GameObject effectRef = null;
    GameObject child = null;
    bool isFirst = false;

    private void Awake()
    {
        SC_EventBus.Instance.SubscribeOnTouchWara((SC_EventBus.OnTouchWara)SetEffect);
    }

    private void Start()
    {
        child = this.transform.Find("pic").gameObject;
    }

    void SetEffect()
    {
        if (isFirst) return;

        isFirst = true;
        //child = picList[Random.Range(0, picList.Length)];
        child.GetComponent<SpriteRenderer>().sprite = picList[Random.Range(0, picList.Length)];

        StartCoroutine(WaitForCreate());
        SC_EventBus.Instance.SubscribeOnTouchWara((SC_EventBus.OnTouchWara)SetEffect);
    }

    IEnumerator WaitForCreate()
    {
        for(int i = 0;i < 3;i++)
        {
            GameObject obj = Instantiate(effectRef);
            obj.transform.position = child.transform.position;
            yield return new WaitForSeconds(1.0f);
        }
    }


}
