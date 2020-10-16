using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    //private Player player;
    //public int playerId = 0;
    private float speed = 5f;
    [SerializeField]
    public GameObject crossHair;

    public GameObject bulletPrefab;

    public float maxHealth = 100f;
    public float currentHealth;
    public HealthBarScript healthBar;
    
    void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        //player = ReInput.players.GetPlayer(playerId);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        transform.position = transform.position = transform.position + movement * Time.deltaTime * speed;

        AimandShoot();

        if(Input.GetKey("v")){
            TakeDamage(10.0f);
            Debug.Log("Health decreased");
        }
   
    }

    void TakeDamage(float damage){
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
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
                bullet.GetComponent<Rigidbody2D>().velocity = shootingDirection * 5.0f;
                bullet.transform.Rotate(0.0f, 0.0f, Mathf.Atan2(shootingDirection.y, shootingDirection.x) * Mathf.Rad2Deg);

                Destroy(bullet, 2.0f);
                Debug.Log("FIRE!");
            }
        } else{
            crossHair.SetActive(false);
        }
    }
}
