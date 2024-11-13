using UnityEngine;
namespace Assignment18
{

public class CharacterTest : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Character[] characters = new Character[2];
        characters[0] = new Soldier();
        characters[1] = new Officer("Officer One", 90, new Position(1, 2, 3));
        foreach (Character character in characters) 
        {
            character.DisplayInfo();
        }
        // Officer attacking Soldier
        Officer officer = characters[1] as Officer;
        Soldier soldier = characters[0] as Soldier;

        if (officer != null && soldier != null)
        {
            Debug.Log("Soldier's Health before attack: soldier.Health");
            officer.Attack(10, soldier, "shooting");
            Debug.Log("Soldier's Health after attack: soldier.Health");
 
        }
    }
 }
}



    // Update is called once per frame
    void Update()
    {
       
