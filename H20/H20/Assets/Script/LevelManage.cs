using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManage : MonoBehaviour
{
    public void LevelOne() { SceneManager.LoadScene("Level1"); }
    public void LevelTwo() { SceneManager.LoadScene("Level2"); }
    public void LevelThree() { SceneManager.LoadScene("Level3"); }
    public void LevelFour() { SceneManager.LoadScene("Level4"); }
    public void LevelFive() { SceneManager.LoadScene("Level5"); }
    public void LevelSix() { SceneManager.LoadScene("Tutorial"); }
    public void BackToStart() { SceneManager.LoadScene("startMenu"); }
}
