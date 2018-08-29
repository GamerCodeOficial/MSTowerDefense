using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {

    public int hp;

    public int[,] grid = new int[20,20];
    
    public Turret[,] turrets = new Turret[20,20];
    public List<GameObject> enemies = new List<GameObject>();

    public void TakeDamage(int dam) {
        hp -= dam;
        if (hp <= 0) print("dead");
    }
    public void AddEnemie(GameObject enemie) {
        enemies.Add(enemie); 
    }
}
