using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using static Unity.Collections.AllocatorManager;
using UnityEditor.SearchService;

public class TextGame_Manager : MonoBehaviour
{
    public int intValue, couValue, advValue;

    public TextMeshProUGUI intTextValue, couTextValue, advTextValue;

    public GameObject StartScreen, Stats, Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7, Scene8, Scene9, Scene10,
        Scene11, Scene12, Scene13,Scene14, Scene15_1, Scene15_2, Scene16, Scene17, Scene18, Scene19, Scene20, Scene21, Scene22, Scene23, Scene24,
        BADENDING1, BADENDING2;

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

    // Exit Button
    public void ExitButton()
    {
        Application.Quit();
    }

    // Reset Button (if died)
    public void ResetButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
        intValue += 1;
        couValue += 1;
        Scene9.SetActive(false);
        Scene10.SetActive(true);
    }
    // Bad Ending 1 Button
    public void Scene9Option2()
    {
        Scene9.SetActive(false);
        BADENDING1.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene10Option1()
    {
        Scene10.SetActive(false);
        Scene11.SetActive(true);
    }

    // Scene 11
    // Dual
    public void Scene11Option1()
    {
        intValue -= 1;
        couValue += 2;
        Scene11.SetActive(false);
        Scene12.SetActive(true);
    }

    // Bad Ending 2 Button
    public void Scene11Option2()
    {
        Scene11.SetActive(false);
        BADENDING2.SetActive(true);

        Stats.SetActive(false);

    }
    public void Scene12Option1()
    {
        Scene12.SetActive(false);
        Scene13.SetActive(true);
    }
    public void Scene13Option1()
    {
        Scene13.SetActive(false);
        Scene14.SetActive(true);
    }

    // Scene 14
    // Dual
    public void Scene14Option1()
    {
        intValue -= 3;
        couValue += 1;
        advValue += 2;
        Scene14.SetActive(false);
        Scene15_1.SetActive(true);
    }
    public void Scene14Option2()
    {
        intValue += 2;
        couValue += 2;
        advValue += 2;
        Scene14.SetActive(false);
        Scene15_2.SetActive(true);
    }
    public void Scene15Option1()
    {
        Scene15_1.SetActive(false);
        Scene16.SetActive(true);
    }
    public void Scene15Option2()
    {
        Scene15_2.SetActive(false);
        Scene16.SetActive(true);
    }
    public void Scene16Option1()
    {
        Scene16.SetActive(false);
        Scene17.SetActive(true);
    }




}
