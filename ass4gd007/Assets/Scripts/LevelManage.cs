using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManage : MonoBehaviour
{
    public void LevelOne() { SceneManager.LoadScene(""); }
    public void LevelTwo() { SceneManager.LoadScene(""); }
    public void LevelThree() { SceneManager.LoadScene(""); }
    public void LevelFour() { SceneManager.LoadScene("Level4"); }
    public void LevelFive() { SceneManager.LoadScene(""); }
    public void BackToStart() { SceneManager.LoadScene("startMenu"); }
}
