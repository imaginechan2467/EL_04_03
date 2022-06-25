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
    GameObject EKeyUI = null;

    private void Awake()
    {
        SC_EventBus.Instance.SubscribeOnTouchWara((SC_EventBus.OnTouchWara)SetEffect);
    }

    private void Start()
    {
        child = this.transform.Find("pic").gameObject;
        EKeyUI = GameObject.Find("EKey");
        EKeyUI.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EKeyUI.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EKeyUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            EKeyUI.SetActive(false);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            EKeyUI.SetActive(false);
        }
    }

    void SetEffect()
    {
        if (isFirst) return;

        isFirst = true;
        child.GetComponent<SpriteRenderer>().sprite = picList[Random.Range(0, picList.Length)];

        //StartCoroutine(WaitForCreate());
        for (int i = 0; i < Random.Range(10, 15); i++)
        {
            GameObject obj = Instantiate(effectRef);
            obj.transform.position = child.transform.position;
            obj.GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-100, 100), Random.Range(10, 100), Random.Range(-30, 30)));
        }
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
