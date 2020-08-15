using System;

[System.Serializable]
public class ClassesJSON{
    public ClassModelJSON[] Classes;
}

[System.Serializable]
public class ClassModelJSON{
    public string CharName;
    public string ClassName;
    public string Skill;
    public int MovementSpeed;
}
