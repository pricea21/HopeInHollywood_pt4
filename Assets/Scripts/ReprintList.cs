using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static GameManager;

public class ReprintList : MonoBehaviour
{
    public TextMeshProUGUI text;
    void Start()
    {
        PrintList();
    }

    void PrintList()
    {
        string gameName = "";
        foreach (MiniGameStruct s in GameManager.instance.miniGameStructs)
        {
            gameName = gameName + s.ToString() + "\n";
        }
        text.text = gameName;
    }
}
