using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public Text GoldText;

    int m_Gold = 0;     // 유저 보유금액

    GameObject hpGage;

    // Start is called before the first frame update
    void Start()
    {
        hpGage = GameObject.Find("hpGage");
    }

    // Update is called once per frame
    void Update()
    {
        if (GoldText != null)
            GoldText.text = "Gold : " + m_Gold;
    }

    public void DecreaseHp()
    {
        this.hpGage.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
