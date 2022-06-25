using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_EventBus
{

    static SC_EventBus instance;
    public static SC_EventBus Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new SC_EventBus();
            }
            return instance;
        }
    }
    private SC_EventBus() { }

    #region プレイヤーが藁人形を操作したとき

    //通知受け取りデリゲート定義
    public delegate void OnTouchWara();
    event OnTouchWara _OnTouchWara;

    //通知受け取り登録
    public void SubscribeOnTouchWara(OnTouchWara _onTouchWara)
    {
        _OnTouchWara += _onTouchWara;
    }

    //通知受け取り解除
    public void UnsubscribeOnTouchWara(OnTouchWara _onTouchWara)
    {
        _OnTouchWara -= _onTouchWara;
    }

    //通知実行
    public void NotifyDeadItemScore()
    {
        if (_OnTouchWara != null)
        {
            _OnTouchWara();
        }
    }

    #endregion
}
