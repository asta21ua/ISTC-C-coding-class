using System;

public class Human //Creating public class Human with following  private fields: GivenName, FamilyName,Gender, Age, Weigth and Heigth 
{
    public string GivenName;
    public string FamilyName;
    public string Gender;
    public int Age;
    public float Weight;
    public float Height;

    public Human(string givenName, string familyName, string gender, int age, float weight, float height)
    {

        this.GivenName = givenName;
        this.FamilyName = familyName;
        this.Gender = gender;
        this.Age = age;
        this.Weight = weight;
        this.Height = height;
    }
}
