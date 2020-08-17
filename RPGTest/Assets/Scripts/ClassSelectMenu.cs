using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClassSelectMenu : MonoBehaviour
{
    public Image ClassImage;

    public TMP_Text CharNameText;
    public TMP_Text ClassNameText;
    public TMP_Text SkillNameText;
    public TMP_Text MovementText;


    public Button PreviousClassButton; 
    public Button NextClassButton; 
    public Button SelectClassButton; 

    public Sprite[] ClassSprites;

    private int currentIndex = 0;

    void Awake()
    {
        PreviousClassButton.onClick.AddListener(() => {
            currentIndex--;
            UpdateUI();
        });

        NextClassButton.onClick.AddListener(() => {
            currentIndex++;
            UpdateUI();
        });

        SelectClassButton.onClick.AddListener(() => {
            PlayerPrefs.SetInt("classId", currentIndex);
            GameManager.StartDelegate();
            gameObject.SetActive(false);
        });
    }
    
    void Start()
    {
        PreviousClassButton.gameObject.SetActive(false);

        UpdateUI();
    }

    private void UpdateUI()
    {
        ClassModelJSON[] classes = ClassManager.GetInstance().ClassJson.Classes;

        currentIndex = Mathf.Clamp(currentIndex, 0, classes.Length);

        CharNameText.text = classes[currentIndex].CharName;
        ClassNameText.text = classes[currentIndex].ClassName;
        SkillNameText.text = classes[currentIndex].Skill;
        MovementText.text = classes[currentIndex].MovementSpeed.ToString();

        PreviousClassButton.gameObject.SetActive(currentIndex > 0);
        NextClassButton.gameObject.SetActive(currentIndex < classes.Length - 1);

        ClassImage.sprite = ClassSprites[currentIndex];
    }
}
