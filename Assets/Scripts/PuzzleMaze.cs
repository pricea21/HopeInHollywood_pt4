using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleMaze : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("PuzzleMaze");
    }

    public void PlatformJumper()
    {
        SceneManager.LoadScene("PlatformJumper");
    }
}
