using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story1 : MonoBehaviour
{
    public int sceneNum;
    // Start is called before the first frame update
    void Awake()
    {
        Button button = gameObject.GetComponent<Button>();
        button.onClick.AddListener (buttonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void buttonClick()
    {
        //print("Button Click");
        SceneManager.LoadScene (sceneNum);
    }
}
