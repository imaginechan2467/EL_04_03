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
    public void NotifyDeadItemScore()
    {
        if (_OnTouchWara != null)
        {
            _OnTouchWara();
        }
    }

    #endregion
}
