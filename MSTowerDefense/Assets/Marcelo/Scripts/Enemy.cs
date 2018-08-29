using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour{
    public Board board;
    public int x;
    public int y;
    public float delay;
    public int hp;
    public int damage;

    private float t;

    private void Start()
    {
        board.AddEnemie(this.gameObject);
    }
    public void Update()
    {
        t += Time.deltaTime;
        if (t >= delay) Act();
        transform.position = new Vector3(x,y,0);
    }

    public void Act() {
        if (x > 15){
            board.TakeDamage(damage);
        }
        else {
            if (board.grid[x + 1, y] == 0) {
                x++;
            }
            if (board.grid[x + 1, y] == 1)
            {
                board.turrets[x + 1, y].TakeDamage(damage);
            }
        }
        t = 0;
    }
    public void TakeDamage(int dam) {
        hp -= dam;
        if (hp <= 0) {
            board.enemies.Remove(this.gameObject);
            Destroy(gameObject);

        }
    }
	
}
