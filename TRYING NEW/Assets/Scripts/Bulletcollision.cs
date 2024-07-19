using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bulletcollision : MonoBehaviour
{
    static int a=0;
    public Animator animator,animator2;
    public int health=100;
<<<<<<< HEAD

    public Animator villananimator,headinganimater ;
    static int EnemyKilled=0;
=======
>>>>>>> 13f6f8293998aecd1e491886689c9d4d30ad4ea6
    public static int damage=50;
    //public Transform  obst;
    public GameObject explosionEffect,obstacle;

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        //Debug.Log("OnCollision");
        //string b=collisionInfo.collider.name;
        if(collisionInfo.tag=="PlyBullet")
        {
            Debug.Log("obstacleCollision");
            health-=damage;
            if(health<=0)
            {
                FindObjectOfType<GameMAnager>().scoreinc();
                explosionEffect.SetActive(true);
                FindObjectOfType<AudioManager>().Play("ObstacleDestroy");
                //Instantiate(explosionEffect,transform.position,transform.rotation);
                Debug.Log("INSTANTIATE");
                Destroy(collisionInfo.gameObject);
                Invoke("Explode",0.5f);
                Debug.Log("INVOKE");
                //Explode();
                //Invoke("Destroyexpl",20f);
            }
        }
        
    }
    void Explode()
    {
        a++;
        // Instantiate(explosionEffect,transform.position,transform.rotation);
        Debug.Log("off");
        Destroy(obstacle);
<<<<<<< HEAD
        EnemyKilled++;
        Debug.Log(EnemyKilled);
        //Debug.Log(EnemyKilled);
        // if(animator != null && animator2 != null){
        //     Debug.Log("yep");
        // animator.SetFloat("EnemyKilled",EnemyKilled);
        // animator2.SetFloat("EnemyKilled",EnemyKilled);}
        //explosionEffect.SetActive(false);
    }

    void Update() {
        
        if ((villananimator != null )&&(headinganimater != null)){
            Debug.Log(EnemyKilled);
            villananimator.SetInteger("EnemyKilled",EnemyKilled);
            headinganimater.SetInteger("EnemyKilled",EnemyKilled);}


        if((EnemyKilled ==1 && w1don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w1don = true ;
        }
        if((EnemyKilled >2 && w2don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w2don = true ;
        }
        if((EnemyKilled >5 && w3don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w3don = true ;
        }
        if((EnemyKilled >9 && w4don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w4don = true ;
        }
=======
        if(animator!=null)
        {
            animator.SetInteger("number",a);
            animator2.SetInteger("number",a);
        }
        
        //explosionEffect.SetActive(false);
>>>>>>> 13f6f8293998aecd1e491886689c9d4d30ad4ea6
    }
    void Destroyexpl()
    {
        //Destroy(explosionEffect);
    }
}
