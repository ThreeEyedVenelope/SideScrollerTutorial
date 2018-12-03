using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{
    private AudioSource audioSource;
    private SpriteRenderer spriteRenderer;
    private BoxCollider2D boxCollider2D;
    private static int coinCount = 0;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            coinCount++;
            Debug.Log("Coin count: " + coinCount);
            audioSource.Play();
            spriteRenderer.enabled = false;
            boxCollider2D.enabled = false;
            Destroy(gameObject, audioSource.clip.length);
        }
    }
}
