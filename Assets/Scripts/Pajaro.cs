using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pajaro : MonoBehaviour
{
    [SerializeField] private float upForce = 350f;

    private bool isDead;
    private Rigidbody2D playerRb;
    private Animator PlayerAnimator;
    void Start()
    {
        playerRb = GetComponent<Rigidbody2D>();
        PlayerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)&& !isDead)
        {
            Flap();

        }
    }
   private void Flap()
    {
        playerRb.velocity = Vector2.zero;
        playerRb.AddForce(Vector2.up * upForce, ForceMode2D.Impulse);
        PlayerAnimator.SetTrigger("Flap");
    }
    private void OnCollisionEnter2D()
    {
        isDead = true;
        PlayerAnimator.SetTrigger("Dead");
        GameManager.Instance.GameOver();
    }
}
