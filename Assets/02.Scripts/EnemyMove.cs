using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    Rigidbody2D rigid;
    public int nextMove;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        Think();

        Invoke("Think", 5);
    }

    void FixedUpdate()
    {   
        //move
        rigid.velocity = new Vector2(nextMove, rigid.velocity.y);

        //platform check
        Vector2 frontVec = new Vector2(rigid.position.x + nextMove, rigid.position.y);
        Debug.DrawRay(frontVec, Vector3.down, new Color(0, 1, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(frontVec, Vector3.down, 1, LayerMask.GetMask("Platforms"));
        if (rayHit.collider == null)
        {
            nextMove *= -1;
            CancelInvoke();
            Invoke("Think", 5);
        }
    }
    //Àç±ÍÇÔ¼ö
    void Think()    
    {
        nextMove = Random.Range(-1, 2);

        Invoke("Think", 5);
    }
}
