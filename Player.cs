using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

/* 
    Color System Scripts:
    Player.cs, PlayerColor.cs, ChangePlayerColor.cs
*/

public class Player : MonoBehaviour
{
    #region Variables
    public static Player instance;
    
    // Movement
    public static Rigidbody2D rb;
    private float speed;

    // Player variables
    public static int coins;
    public static int coinsAmount;
    public static int life;
    public static bool warningOn;

    // Setting the Player chosen color
    public static Color32 playerColor;
    Renderer p_Renderer;
    #endregion

    #region Main Functions

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        //Movement
        rb = GetComponent<Rigidbody2D>();
        speed = 300;

        // Player variables
        coins = 0;
        life = 5;
        coinsAmount = 0;
        coinsAmount = PlayerPrefs.GetInt("Coins");
        warningOn = true;
        

        // Setting the Player chosen color
        p_Renderer = GetComponent<Renderer>();

        ColorSelect();
    }

    void FixedUpdate()
    {
        //Movement
        rb.velocity = new Vector2(PlayerMovement.moveH * speed * Time.deltaTime, PlayerMovement.moveV * speed * Time.deltaTime);
    }

    private void Update()
    {
        EndGame();
    }

    #endregion

    #region Functions

    void ColorSelect()
    {
        playerColor = ChangePlayerColor.color;
        p_Renderer.material.color = playerColor;
    }
    void EndGame()
    {
        if (life < 0)
        {
            life = 0;
            AdsUnity.InterstitialVideo();
            SceneManager.LoadScene("Menu");
        }
    }

    #endregion

    #region Collisions

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            life--;
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(col.gameObject);
            SoundCoin.CoinSound();
        }

        if (col.gameObject.CompareTag("ChangeLevel") && coins < 10)
        {
            warningOn = true;
        }
        else if (col.gameObject.CompareTag("ChangeLevel") && coins >= 10)
        {
            warningOn = false;
            LevelChange.ActivateButton();
        }
    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("ChangeLevel") && coins <= 10)
        {
            warningOn = false;
            LevelChange.DisableButton();
        }
        else if (col.gameObject.CompareTag("ChangeLevel") && coins > 10)
        {
            warningOn = false;
            LevelChange.DisableButton();
        }
    }
    public IEnumerator Knockback(float duration, float power, Transform obj)
    {
        float timer = 0;
        while(duration > timer)
        {
            timer += Time.deltaTime;
            Vector2 direction = (obj.transform.position - this.transform.position).normalized;
            rb.AddForce(-direction * power);
        }
        yield return 0;
    }
    #endregion
}
