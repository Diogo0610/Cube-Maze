using UnityEngine;
public class Spike : MonoBehaviour
{
    //Knockback
    private float knockbackDuration;
    private float knockbackPower;

    void Start()
    {
        //Knockback
        knockbackDuration = 1;
        knockbackPower = 70;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Player.instance.Knockback(knockbackDuration, knockbackPower, this.transform));
            SpikeSound.SpikeTouchSound();
        }
    }
}
