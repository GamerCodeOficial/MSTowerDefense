using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

    public Board board;
    public int x;
    public int y;
    public float delay;
    public int hp;
    public int damage;
    public int range;

    private float t;


    // Use this for initialization
    void Start () {
        board.grid[x, y] = 1;
        board.turrets[x, y] = this;
    }
	
	// Update is called once per frame
	void Update () {
        t += Time.deltaTime;
        if (t >= delay) Act();
        transform.position = new Vector3(x, y, 0);
    }
    public void Act()
    {
        foreach (GameObject en in board.enemies) {
            Enemy e = en.GetComponent<Enemy>();
            if (e.y == y && e.x>x-range) {
                e.TakeDamage(damage);
            }
        }
        t = 0;
    }
    public void TakeDamage(int dam)
    {
        hp -= dam;
        if (hp <= 0)
        {
            board.grid[x, y] = 0;
            board.turrets[x, y] = null;
            Destroy(gameObject);

        }
    }
}
