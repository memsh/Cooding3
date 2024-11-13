using UnityEngine;

namespace Assignment18
{

public struct Position
{
  public float X, Y ,Z;
  public Position(float x, float y, float z)
  {
    X = x;
    Y = y;
    Z = z;

  }
  public void PrintPosition(
    {
        Debug.Log("Potion: (X, Y, Z)");
    }
  
  public class Character
  {
    public string name;
    private int health;
    protected Position position;
    public int Health 
    {
        get {return health;}
        set {
            if (value > 100) health = 100;
            else if (value < 0) health =0; 
             else health = value;
         }  
    }
    public Character(string name, int initialHealth, Position pos)
    {
        this.name = name;
        this.Health = initialHealth;
        this.position = pos;
    }
    public Character() : this("No name", 100, new Position(0, 0, 0))
    {

    }
    
    public virtual void DisplayInfo()
    {
        Debug.Log("Name: name, Health: Health");
        position.PrintPosition();
    }
    public void Attack(int damage, Character target)
    {
        target.Health -= damage;
        Debug.Log("name attacked target.name for damage damage.");
    }
      public void Attack(int damage, Character target, string attackType)
      {
        Attack(damage, target);
        Debug.Log("name used attackType.");
      }
      public static void ShowPlayerCount()
      {

      }
      public class Soldier : Character
      {
        public Soldier(string name, int initialHealth, Position pos) : base(name, initialHealth, pos)
        {

        }
        public Soldier() : base() 
        {

        }
        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }

      }
      public class Officer : Character
      {
        public Officer(string name, int initialHealth, Position pos) : base(name, initialHealth, pos) 
        {

        }
        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }
      }
  }
 }
}
