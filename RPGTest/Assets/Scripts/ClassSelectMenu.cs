using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassSelectMenu : MonoBehaviour
{
    public TMP_Text CharNameText;
    public TMP_Text ClassNameText;
    public TMP_Text SkillNameText;
    public TMP_Text MovementText;


    public Button PreviousClassButton; 
    public Button NextClassButton; 

    private int currentIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        PreviousClassButton.gameObject.SetActive(false);

        FillTexts();
    }

    private void FillTexts()
    {
        CharNameText.text = ClassManager.GetInstance().ClassJson.Classes[currentIndex].CharName;
        ClassNameText.text = ClassManager.GetInstance().ClassJson.Classes[currentIndex].ClassName;
        SkillNameText.text = ClassManager.GetInstance().ClassJson.Classes[currentIndex].Skill;
        MovementText.text = ClassManager.GetInstance().ClassJson.Classes[currentIndex].MovementSpeed.ToString();
    }
}
