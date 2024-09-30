using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    //private float health = 0;
    private EnemyHealth enemyHealth;

    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
        enemyHealth = GetComponent<EnemyHealth>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GotHit()
    {
        if (enemyHealth != null)
        {
            GameManager.Instance.IncrementScore();
            enemyHealth.TakeDamage(Random.Range(10,50));
            animator.SetTrigger("GotHit");
            hitParticles.Emit(5);
            audioSource.Play();
        }
    }
}
