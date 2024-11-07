using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         Player p1 = new Player();
         Player p2 = new Player();
         
        p1.InitializePlayer("BeBe", 50);
        p2.InitializePlayer("TeTo", 75);

        p1.Heal(20);
        p2.Heal(true);
          
        Player.ShowPlayerCount();

    }

  
}
