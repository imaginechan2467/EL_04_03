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
    public void NotifyOnTouchWara()
    {
        if (_OnTouchWara != null)
        {
            _OnTouchWara();
        }
    }

    #endregion

    #region 写真を変えたとき

    //通知受け取りデリゲート定義
    public delegate void OnChangedPic();
    event OnChangedPic _OnChangedPic;

    //通知受け取り登録
    public void SubscribeOnChangedPic(OnChangedPic _onChangedPic)
    {
        _OnChangedPic += _onChangedPic;
    }

    //通知受け取り解除
    public void UnsubscribeOnChangedPic(OnChangedPic _onChangedPic)
    {
        _OnChangedPic -= _onChangedPic;
    }

    //通知実行
    public void NotifyOnChangedPic()
    {
        if (_OnChangedPic != null)
        {
            _OnChangedPic();
        }
    }

    #endregion

    #region 敵にあたったとき

    //通知受け取りデリゲート定義
    public delegate void OnHitEnemy();
    event OnHitEnemy _OnHitEnemy;

    //通知受け取り登録
    public void SubscribeOnHitEnemy(OnHitEnemy _onHitEnemy)
    {
        _OnHitEnemy += _onHitEnemy;
    }

    //通知受け取り解除
    public void UnsubscribeOnHitEnemy(OnHitEnemy _onHitEnemy)
    {
        _OnHitEnemy -= _onHitEnemy;
    }

    //通知実行
    public void NotifyOnHitEnemy()
    {
        if (_OnHitEnemy != null)
        {
            _OnHitEnemy();
        }
    }

    #endregion
}
