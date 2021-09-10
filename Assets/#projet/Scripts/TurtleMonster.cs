using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleMonster : MovingMonster
{
    override protected void Update()                       // protected pour que pas ds inspecteur ms transmis au enfant
    {
        Vector2 start = (Vector2)transform.position + Vector2.down*0.6f;
        Vector2 direction = Vector2.down;


        if (speed.x < 0)
        {
            start += Vector2.left * 0.6f;
        }
        else
        {
            start += Vector2.right * 0.6f;
        }

        Debug.DrawRay(start, direction * hitRange, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        if (hit.collider == null)   // voir que l'on touche bien quelque chose
        {
            speed.x *= -1;
        }



        base.Update();
    }
    
}
