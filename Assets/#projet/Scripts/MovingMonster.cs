using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingMonster : Monster
{
    public Vector2 speed = Vector2.zero; // on met la    vitesse à zero
    private SpriteRenderer mySpriteRenderer;

    public float hitRange = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }


    // Update is called once per frame
    protected virtual void Update()
    {
        Vector2 start;
        Vector2 direction;

        // déplacement
        
        if(speed.x < 0)
        {
            mySpriteRenderer.flipX = true;
            start = (Vector2)transform.position + Vector2.left * 0.6f;
            direction = Vector2.left;
        }
        else
        {
            mySpriteRenderer.flipX = false;
            start = (Vector2)transform.position + Vector2.right * 0.6f;
            direction = Vector2.right;
        }
        // mySpriteRenderer.flipX = speed.x;   autre manière d'écrire --> égalité de booléen 

        Debug.DrawRay(start, direction * hitRange, Color.red);
        RaycastHit2D hit = Physics2D.Raycast(start, direction, hitRange);

        if(hit.collider != null)
        {
            speed.x *= -1;
        }

        Vector2 deplacement = speed * Time.deltaTime;
        transform.position += (Vector3)deplacement;   // casting on transforme le vecteur 2 déplacement en vecteur 3
                                                      // le transform reste un vecteur 3 mm en 2D
    }
}
