/*
 * (Austin Buck)
 * (Assignment 5B)
 * (When mouse 1 is pressed the gun fires a raycast)
 */
using UnityEngine;

public class ShootWithRaycasts : MonoBehaviour
{
    public ParticleSystem muzzleFlash;

    public float damage = 10f;
    public float range = 100f;
    public Camera cam;

    public float hitForce = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        muzzleFlash.Play();

        RaycastHit hitInfo;
        if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hitInfo, range))
        {
            Debug.Log(hitInfo.transform.gameObject.name);

            Target target = hitInfo.transform.gameObject.GetComponent<Target>();

            if(target != null)
            {
                target.TakeDamage(damage);
            }

            if(hitInfo.rigidbody != null)
            {
                hitInfo.rigidbody.AddForce(cam.transform.TransformDirection(Vector3.forward) * hitForce, ForceMode.Impulse);
            }

        }
    }
}
