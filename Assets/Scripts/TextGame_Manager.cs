using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static Unity.Collections.AllocatorManager;

public class TextGame_Manager : MonoBehaviour
{
    public int intValue, couValue, advValue;

    public TextMeshProUGUI intTextValue, couTextValue, advTextValue;
    
    public GameObject StartScreen, Stats, Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7, Scene8, Scene9, Scene10, 
        Scene11, Scene12, BADENDING1;

    //public Image StartBG;
    //public Sprite Scene0BG;


    void Start()
    {
        intValue = 0; couValue = 0; advValue = 0;   
    }

    void Update()
    {
        intTextValue.text = intValue.ToString();
        couTextValue.text = couValue.ToString();    
        advTextValue.text = advValue.ToString();
        
    }

    public void StartButton()
    {
        //StartBG.sprite = Scene0BG;
        StartScreen.SetActive(false);
        Scene1.SetActive(true);
    }
    public void ExitButton()
    {
        Application.Quit();
    }

    public void Scene1Option1()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(true);
    }

    public void Scene2Option1()
    {
        intValue += 5;
        advValue += 5;
        couValue += 5;
        Scene2.SetActive(false);
        Scene3.SetActive(true);

        Stats.SetActive(true);
    }

    public void Scene3Option1()
    {
        Scene3.SetActive(false);
        Scene4.SetActive(true);
    }
    public void Scene4Option1()
    {
        Scene4.SetActive(false);
        Scene5.SetActive(true);
    }

    // SCENE 5
    // DUAL

    public void Scene5Option1()
    {
        intValue += 2;
        Scene5.SetActive(false);
        Scene6.SetActive(true);
    }

    public void Scene5Option2()
    {
        intValue -= 2;
        advValue += 3;
        Scene5.SetActive(false);
        Scene7.SetActive(true);
    }

    public void Scene6Option1()
    {
        Scene6.SetActive(false);
        Scene8.SetActive(true);
    }
    public void Scene7Option1()
    {
        Scene7.SetActive(false);
        Scene8.SetActive(true);
    }
    public void Scene8Option1()
    {
        Scene8.SetActive(false);
        Scene9.SetActive(true);
    }

    // SCENE 9
    // DUAL
    public void Scene9Option1()
    {
        Scene9.SetActive(false);
        Scene10.SetActive(true);
    }
    public void Scene9Option2()
    {
        Scene9.SetActive(false);
        BADENDING1.SetActive(true);
    }



}
