using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManage : MonoBehaviour
{
    public void LevelOne() { SceneManager.LoadScene("Story2"); }
    public void LevelTwo() { SceneManager.LoadScene("Story3"); }
    public void LevelThree() { SceneManager.LoadScene("Story4"); }
    public void LevelFour() { SceneManager.LoadScene("Story5"); }
    public void LevelFive() { SceneManager.LoadScene("Story6"); }
    public void LevelSix() { SceneManager.LoadScene("Story1"); }
    public void BackToStart() { SceneManager.LoadScene("startMenu"); }
}
