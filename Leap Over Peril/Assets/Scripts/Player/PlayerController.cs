using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;
    Animator animator;

    [Header("Scripts")]
    public Manager manager;
    public AudioManager audioManager;


    [Header("Jump")]
    [SerializeField] float jumpSpeed;
    [SerializeField] bool isGround = true;

    [Header("Game Over")]
    public bool isDead = false;


    [Header("Particle System")]
    [SerializeField] ParticleSystem explosionParticle;
    [SerializeField] ParticleSystem walkParticle;


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();

    }

    private void Update()
    {
        animator.SetFloat("Speed_f", 0.55f);

        Jump();
    }

    void Jump()
    {
        if (Input.GetKey(KeyCode.Space) && isGround==true && isDead==false)
        {
            walkParticle.Stop();

            rigidbody.AddForce(Vector3.up * jumpSpeed , ForceMode.Impulse);

            animator.SetTrigger("Jump_trig");

            AudioManager.Instance.PlaySFX("Jump");

            isGround = false;
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;

            walkParticle.Play();

        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            manager.totalHeart -= 1;
            manager.CanvasHeartText();



            AudioManager.Instance.PlaySFX("Crash");


            if (manager.totalHeart <= 0)
            {
                explosionParticle.Play();
                walkParticle.Stop();

                isDead = true;

                manager.totalHeart = 0;
                manager.CanvasHeartText();

                animator.SetBool("Death_b",true);
                
                StartCoroutine(ScenePaasTime());
                

            }
        }

        if (other.gameObject.CompareTag("Score"))
        {
            manager.totalScore += 1;
            manager.CanvasScoreText();

        }
    }


    IEnumerator ScenePaasTime()
    {
        yield return new WaitForSeconds(4.0f);
        SceneManager.LoadScene(1);
    }
}
