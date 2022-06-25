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

    #region �v���C���[���m�l�`�𑀍삵���Ƃ�

    //�ʒm�󂯎��f���Q�[�g��`
    public delegate void OnTouchWara();
    event OnTouchWara _OnTouchWara;

    //�ʒm�󂯎��o�^
    public void SubscribeOnTouchWara(OnTouchWara _onTouchWara)
    {
        _OnTouchWara += _onTouchWara;
    }

    //�ʒm�󂯎�����
    public void UnsubscribeOnTouchWara(OnTouchWara _onTouchWara)
    {
        _OnTouchWara -= _onTouchWara;
    }

    //�ʒm���s
    public void NotifyOnTouchWara()
    {
        if (_OnTouchWara != null)
        {
            _OnTouchWara();
        }
    }

    #endregion

    #region �ʐ^��ς����Ƃ�

    //�ʒm�󂯎��f���Q�[�g��`
    public delegate void OnChangedPic();
    event OnChangedPic _OnChangedPic;

    //�ʒm�󂯎��o�^
    public void SubscribeOnChangedPic(OnChangedPic _onChangedPic)
    {
        _OnChangedPic += _onChangedPic;
    }

    //�ʒm�󂯎�����
    public void UnsubscribeOnChangedPic(OnChangedPic _onChangedPic)
    {
        _OnChangedPic -= _onChangedPic;
    }

    //�ʒm���s
    public void NotifyOnChangedPic()
    {
        if (_OnChangedPic != null)
        {
            _OnChangedPic();
        }
    }

    #endregion

    #region �G�ɂ��������Ƃ�

    //�ʒm�󂯎��f���Q�[�g��`
    public delegate void OnHitEnemy();
    event OnHitEnemy _OnHitEnemy;

    //�ʒm�󂯎��o�^
    public void SubscribeOnHitEnemy(OnHitEnemy _onHitEnemy)
    {
        _OnHitEnemy += _onHitEnemy;
    }

    //�ʒm�󂯎�����
    public void UnsubscribeOnHitEnemy(OnHitEnemy _onHitEnemy)
    {
        _OnHitEnemy -= _onHitEnemy;
    }

    //�ʒm���s
    public void NotifyOnHitEnemy()
    {
        if (_OnHitEnemy != null)
        {
            _OnHitEnemy();
        }
    }

    #endregion
}
