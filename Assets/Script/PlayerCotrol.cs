using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCotrol : MonoBehaviour
{
    public Animator anim;
    public Rigidbody2D rigid;
    public UIControl script_UIControl;
    bool bTreadOnGround = true;
    int jumpNum = 0;
    private void Update()
    {
        bTreadOnGround = false;
        RaycastHit2D hit;
        if (hit = Physics2D.Raycast(transform.position, -transform.up, 0.1f))
        {
            Debug.Log(hit.transform.tag);
            if (hit.transform.tag == "Ground")
            {
                bTreadOnGround = true;
                jumpNum = 0;
            }
        }

        if (transform.position.x < -10)
        {
            script_UIControl.End();
            Destroy(gameObject);
        }
        else if (transform.position.x < -5)
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }

        script_UIControl.CumulativeScore(Time.deltaTime*10);

        anim.SetBool("TreadOnGround", bTreadOnGround);
    }
    public void Button_Attack()
    {
        anim.SetTrigger("Attack");
    }
    public void Button_Jump()
    {
        if (jumpNum < 2)
        {
            jumpNum++;
            rigid.velocity = new Vector2(0, 15);
            anim.SetTrigger("Jump");
        }
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Enemy")
        {
            script_UIControl.End();
            Destroy(gameObject);
        }
    }
}
