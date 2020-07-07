using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public Behaviour[] disableOnDeath;
    public float health;
    public float MAXHEALTH;

    

    private void Start()
    {
        if (gameObject.tag == "Player")
        {
            health = MAXHEALTH;
        }
        else if(gameObject.tag == "Enemy")
        {
            health = Random.Range(50, 250);
        }

    }
    public Image healthbar;
    public void TakeDamage(float amount)
    {
        health -= amount;

        try
        {
            healthbar.fillAmount = health / MAXHEALTH;

        }

        catch
        {

        }


        if (health <= 0)
        {
            health = 0;
            Die();
        }

    }
    void Die()
    {
        if(gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
        if(gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }

        
    }
}
