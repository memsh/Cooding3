using UnityEngine;

public class Player 
{
     public string playerName;
     public int health;
     public static int playerCount;
   

     public void InitializePlayer(string name, int initializePlayer)
     {
        playerName = name;
        health = initializePlayer;
        playerCount++;
        Debug.Log("playerName has been initialize with health");
     }

     public void Heal(int amount)
      {
            health += amount;
            Debug.Log(health);
      }
     public void Heal(bool fullRestore)
      {
         if (fullRestore)
         {
            health = 100;
            Debug.Log("Fully Restored");
         }
        
      }
     
        public  static void ShowPlayerCount()
        {
        Debug.Log("Total number of players: ");
    
        }
        

}
