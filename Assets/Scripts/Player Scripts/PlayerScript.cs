using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private float speed = 5f;
    [SerializeField] public GameObject crossHair;

    public GameObject bulletPrefab;
    public bool isImmune = false;
    public float immunityTime = 5.0f;

    public GameObject continuePanel;

    public Animator defaultPlayerAnim;

    public AudioSource playerAudioSource;
    public AudioClip fireClip, hurtClip, dieClip, healthClip, immunityClip;

    void Update()
    {
        bool playerAlive = GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().isAlive;
        if(playerAlive == true){
            
            Movement();
            AimandShoot();

            if(isImmune == true){
                immunityTime -= Time.deltaTime;
                Debug.Log("Immunity Ongoing");

                if(immunityTime <= 0.0f){
                    timerEnded();
                    Debug.Log("DING DING, Immunity stopped");
                }
            }
        }
        else{
            continuePanel.SetActive(true);
            GameObject.Find("Spawner Controller").GetComponent<SpawnerController>().spawnAllowed = false;
        }
    }

    private void AimandShoot(){
        Vector3 aim = new Vector3(Input.GetAxis("AimHorizontal"), Input.GetAxis("AimVertical"), 0.0f);
        Vector2 shootingDirection = new Vector2(Input.GetAxis("AimHorizontal"), Input.GetAxis("AimVertical"));
        //AimHorizontal, AimVertical
        //Mouse X, Mouse Y
        if(aim.magnitude > 0.0f){
            aim.Normalize();
            aim *= 3f;
            crossHair.transform.localPosition = aim;
            crossHair.SetActive(true);
            Debug.Log("Currently Aiming");
            
            shootingDirection.Normalize();
            if(Input.GetButtonDown("Jump")){ //Fire1, Jump
                GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody2D>().velocity = shootingDirection * 10.0f;
                bullet.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);
                playerAudioSource.PlayOneShot(fireClip);

                Destroy(bullet, 2.0f);
                Debug.Log("FIRE!");
            }
        } else{
            crossHair.SetActive(false);
        }
    }

    private void Movement(){
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        
        defaultPlayerAnim.SetFloat("Horizontal", movement.x);
        defaultPlayerAnim.SetFloat("Vertical", movement.y);
        defaultPlayerAnim.SetFloat("Magnitude", movement.magnitude);

        transform.position = transform.position + movement * Time.deltaTime * speed;
    }

    void OnTriggerEnter2D(Collider2D target) {
        if(isImmune == false){
            if (target.tag == "Enemy5") {
            GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 5f;
            Debug.Log("You collided with an Enemy. Decrease health by 5 points");
            playerAudioSource.PlayOneShot(hurtClip);

            }

            else if (target.tag == "Enemy10") {
            GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 10f;
            Debug.Log("You collided with an Enemy. Decrease health by 10 points");
            playerAudioSource.PlayOneShot(hurtClip);

            }

            else if (target.tag == "Enemy20") {
            GameObject.Find("Gameplay Controller").GetComponent<HealthScript>().currentHealth -= 20f;
            Debug.Log("You collided with an Enemy. Decrease health by 20 points");
            playerAudioSource.PlayOneShot(hurtClip);
            
            }
        }

        else{
            Debug.Log("Your vulnerable to the virus");
        }
		
	}

    void timerEnded(){
        isImmune = false;
        immunityTime = 5.0f;
    }
}
