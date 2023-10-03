//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.Serialization;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] public MiniGameStruct[] miniGameStructs;
    //public TextMeshProUGUI text;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }


    public void SetMinigameComplete (string name)
    {
        MiniGameStruct game = miniGameStructs.First(q => q.gameTitle == name);
        game.complete = true;
    }

    [Serializable] public struct MiniGameStruct
    {
        [SerializeField] public string gameTitle;
        [SerializeField] public bool complete;

        public override readonly string ToString()
        {
            string newGame = gameTitle;
            if (complete)
                newGame = "<s>" + gameTitle + "</s>";
            return newGame;
        }
    }
}
