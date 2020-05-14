using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// This script defines which sprite the 'Player" uses and its health.
/// </summary>
namespace Shooter
{
    public class Player : MonoBehaviour
    {
        public GameObject HealthpowerUp;
     //   public Slider Slider;
        public Image HealthImg;
        public GameObject GameOverScreen;
        public GameObject destructionFX;

        public static Player instance;

        private void Awake()
        {

            if (instance == null)
                instance = this;
        }

        //method for damage proceccing by 'Player'
        public void GetDamage(int damage)
        {
            Destruction();
        }

        //'Player's' destruction procedure
        void Destruction()
        {
            Instantiate(destructionFX, transform.position, Quaternion.identity); //generating destruction visual effect and destroying the 'Player' object
            //  Destroy(gameObject);
            //   GameOverScreen.SetActive(true);

            Health(0.35f);


        }
        public void Health(float Value)
        {
          //  Slider.value -= Value;
            HealthImg.fillAmount -= Value;
            if (HealthImg.fillAmount <= 0)
            {
               Destroy(gameObject);
          GameOverScreen.SetActive(true);
            }

        }



    }
}
















