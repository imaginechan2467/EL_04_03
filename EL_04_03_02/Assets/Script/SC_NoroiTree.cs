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
    float time = 0.0f;

    private void Awake()
    {
        SC_EventBus.Instance.SubscribeOnTouchWara((SC_EventBus.OnTouchWara)SetEffect);
    }

    private void Start()
    {
        child = this.transform.Find("pic").gameObject;
    }

    private void Update()
    {
        time += Time.deltaTime;
        if(time >= 10.0f)
        {
            Destroy(this.gameObject);
        }
    }

    void SetEffect()
    {
        if (isFirst) return;

        isFirst = true;
        child.GetComponent<SpriteRenderer>().sprite = picList[Random.Range(0, picList.Length)];

        StartCoroutine(WaitForCreate());
        SC_EventBus.Instance.SubscribeOnTouchWara((SC_EventBus.OnTouchWara)SetEffect);
    }

    IEnumerator WaitForCreate()
    {
        for(int i = 0;i < Random.Range(10,15);i++)
        {
            GameObject obj = Instantiate(effectRef);
            obj.transform.position = child.transform.position;
            yield return new WaitForSeconds(1.0f);
        }
    }


}
