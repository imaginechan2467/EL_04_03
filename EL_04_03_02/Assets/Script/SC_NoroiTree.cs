using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_NoroiTree : MonoBehaviour
{
    [SerializeField] GameObject effectRef = null;
    GameObject child = null;

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
        StartCoroutine(WaitForCreate());
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
