using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
// using static Unity.Collections.AllocatorManager;
// using UnityEditor.SearchService;

public class TextGame_Manager : MonoBehaviour
{
    public int intValue, couValue, advValue;

    public TextMeshProUGUI intTextValue, couTextValue, advTextValue;

    public GameObject StartScreen, Stats, Scene1, Scene2, Scene3, Scene4, Scene5, Scene6, Scene7, Scene8, Scene9, Scene10,
        Scene11, Scene12, Scene13, Scene14, Scene15_1, Scene15_2, Scene16, Scene17, Scene18, Scene19, Scene20, Scene21, Scene21_1, Scene22, Scene23, Scene24,
        Scene25, Scene26, Scene27, Scene28, Scene28_1, Scene29, Scene30, Scene31, Scene31_1, Scene32, Scene33, Scene34, Scene34_1, Scene35,
        BADENDING1, BADENDING2, BADENDING3, BADENDING4,
        GOODENDING_WAGO, BADENDING_WAGO, BADENDING2_WAGO, GOODENDING_IRO, BADENDING_IRO, BADENDING2_IRO, GOODENDING_TORA, BADENDING_TORA, BADENDING2_TORA;

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
        couValue += 2;
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
        advValue += 3;
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
        couValue += 2;
        advValue += 2;
        Scene14.SetActive(false);
        Scene15_1.SetActive(true);
    }
    public void Scene14Option2()
    {
        intValue += 2;
        couValue -= 2;
        advValue -= 1;
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
    public void Scene17Option1()
    {
        Scene17.SetActive(false);
        Scene18.SetActive(true);
    }
    public void Scene18Option1()
    {
        Scene18.SetActive(false);
        Scene19.SetActive(true);
    }
    public void Scene19Option1()
    {
        Scene19.SetActive(false);
        Scene20.SetActive(true);
    }
    public void Scene20Option1()
    {
        Scene20.SetActive(false);
        Scene21.SetActive(true);
    }
    public void Scene21Option1()
    {
        Scene21.SetActive(false);
        Scene21_1.SetActive(true);
    }
    public void Scene21_1Option1()
    {
        Scene21_1.SetActive(false);
        Scene22.SetActive(true);
    }
    public void Scene22Option1()
    {
        Scene22.SetActive(false);
        Scene23.SetActive(true);
    }
    public void Scene23Option1()
    {
        Scene23.SetActive(false);
        Scene24.SetActive(true);
    }
    // Scene 24
    // Dual
    public void Scene24Option1()
    {
        intValue += 2;
        advValue -= 1;
        Scene24.SetActive(false);
        Scene25.SetActive(true);
    }
    public void Scene24Option2()
    {
        Scene24.SetActive(false);
        BADENDING3.SetActive(true);

        Stats.SetActive(false);
    }
    // Scene 25
    // Dual
    public void Scene25Option1()
    {
        advValue -= 1;
        Scene25.SetActive(false);
        Scene26.SetActive(true);
    }
    // Bad Ending 3
    public void Scene25Option2()
    {
        Scene25.SetActive(false);
        BADENDING3.SetActive(true);

        Stats.SetActive(false);
    }
    // Scene 26
    // Triple

    // Astronomy
    public void Scene26Option1()
    {
        Scene26.SetActive(false);
        Scene27.SetActive(true);
    }

    // Music Room
    public void Scene26Option2()
    {
        Scene26.SetActive(false);
        Scene30.SetActive(true);
    }
    
    // Alchemi Room
    public void Scene26Option3()
    {
        Scene26.SetActive(false);
        Scene33.SetActive(true); // IDOL
    }

    // Scene 27
    // Dual
    // CHOICE WAGO
    public void Scene27Option1()
    {
        intValue += 1;
        couValue += 1;
        advValue += 1;
        Scene27.SetActive(false);
        Scene28.SetActive(true);
    }
    public void Scene27Option2()
    {
        Scene27.SetActive(false);
        BADENDING4.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene28Option1()
    {
        Scene28.SetActive(false);
        Scene28_1.SetActive(true);
    }

    // Dual 
    public void Scene28_1Option1()
    {
        
        if (intValue == 10 || intValue >= 10)
        { 
          Scene28_1.SetActive(false);
          Scene29.SetActive(true);


        Stats.SetActive(false);
        }
        else
        {
            Scene28_1.SetActive(false);
            BADENDING2_WAGO.SetActive(true);
        }
    }
    public void Scene28_1Option2()
    {
        Scene28_1.SetActive(false);
        BADENDING_WAGO.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene29Option1()
    {
        Scene29.SetActive(false);
        GOODENDING_WAGO.SetActive(true);
    }

    // CHOICE: IRO
    public void Scene30Option1()
    {
        intValue += 1;
        couValue += 1;
        advValue += 1;
        Scene30.SetActive(false);
        Scene31.SetActive(true);
    }
    public void Scene30Option2()
    {
        Scene30.SetActive(false);
        BADENDING4.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene31Option1()
    {
        Scene31.SetActive(false);
        Scene31_1.SetActive(true);
    }
    // Dual 
    public void Scene31_1Option1()
    {

        if (couValue == 10 || couValue >= 10)
        {
            Scene31_1.SetActive(false);
            Scene32.SetActive(true);


            Stats.SetActive(false);
        }
        else
        {
            Scene31_1.SetActive(false);
            BADENDING2_IRO.SetActive(true);
        }
    }
    public void Scene31_1Option2()
    {
        Scene31_1.SetActive(false);
        BADENDING_IRO.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene32Option1()
    {
        Scene32.SetActive(false);
        GOODENDING_IRO.SetActive(true);
    }

    // CHOICE: Tora
    public void Scene33Option1()
    {
        intValue += 1;
        couValue += 1;
        advValue += 1;
        Scene33.SetActive(false);
        Scene34.SetActive(true);
    }
    public void Scene33Option2()
    {
        Scene33.SetActive(false);
        BADENDING4.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene34Option1()
    {
        Scene34.SetActive(false);
        Scene34_1.SetActive(true);
    }
    // Dual 
    public void Scene34_1Option1()
    {

        if (advValue == 10 || advValue >= 10)
        {
            Scene34_1.SetActive(false);
            Scene35.SetActive(true);


            Stats.SetActive(false);
        }
        else
        {
            Scene34_1.SetActive(false);
            BADENDING2_TORA.SetActive(true);
        }
    }
    public void Scene34_1Option2()
    {
        Scene34_1.SetActive(false);
        BADENDING_TORA.SetActive(true);

        Stats.SetActive(false);
    }
    public void Scene35Option1()
    {
        Scene32.SetActive(false);
        GOODENDING_TORA.SetActive(true);
    }


}
