using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_ItemEquiped : MonoBehaviour
{
    public static GUI_ItemEquiped Instance;

    [SerializeField] Image slotHelmet;
    [SerializeField] Image iconHelmet;
    [SerializeField] Image slotArmor;
    [SerializeField] Image iconArmor;
    [SerializeField] Image slotHandL;
    [SerializeField] Image iconHandL;
    [SerializeField] Image slotHandR;
    [SerializeField] Image iconHandR;

    private List<Color> colors = new List<Color>();

    private void Awake()
    {
        Instance = this;
        SetColorList();
    }

    private void SetColorList()
    {
        colors.Add(new Color(0.7169812f, 0.5083325f, 0.01690993f, 1f)); // common
        colors.Add(new Color(0.2722067f, 0.5849056f, 0.13519505f, 1f)); // uncommom
        colors.Add(new Color(0.1541919f, 0.3933419f, 0.71223475f, 1f)); // rare
        colors.Add(new Color(0.4543215f, 0.2126654f, 0.99174132f, 1f)); // epic
        colors.Add(new Color(0.8971235f, 0.8946123f, 0.21643756f, 1f)); // legendary
        colors.Add(new Color(0.9912354f, 0.3451256f, 0.61234353f, 1f)); // mythic
    }

    public void SetItemGUI(Item item)
    {
        Color tierColor = colors[(int)item.tier];

        switch (item.type)
        {
            case Item.ItemType.Helmet:
                slotHelmet.color = tierColor;
                if(item.icon != null)
                    iconHelmet.sprite = item.icon;
                break;
            case Item.ItemType.Armor:
                slotArmor.color = tierColor;
                if (item.icon != null)
                    iconArmor.sprite = item.icon;
                break;
            case Item.ItemType.Weapon:
                slotHandL.color = tierColor;
                if (item.icon != null)
                    iconHandL.sprite = item.icon;
                break;
            case Item.ItemType.Shield:
                slotHandR.color = tierColor;
                if (item.icon != null)
                    iconHandR.sprite = item.icon;
                break;
        }
    }
}
