using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UISystem;
using Character;
using LangSystem;
using TMPro;

public class GUI_ShowCharacterInfor : GUIPopUp
{
    [SerializeField] xText _name;
    [SerializeField] TextMeshProUGUI _lv;
    [SerializeField] TextMeshProUGUI _hp;
    [SerializeField] TextMeshProUGUI _attackValue;


    public void SetInfor(string name, NetworkCharacterController target) {
        _name.SetText(name);
        _lv.text = target.stat.GetLevel().ToString();
        _hp.text = target.stat.HP.ToString();
        _attackValue.text = target.GetAttackValue().ToString();

    }
}
