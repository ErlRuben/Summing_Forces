using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Forcelist : MonoBehaviour
{
    public Vector3 velocityVector;
    public Vector3 netForceVector;
    public List<Vector3> forceVectorList = new List<Vector3>();
    public float mass;
    public GameObject good;
    public GameObject bad;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        AddForces();
        UpdateVelocity();
        if(netForceVector == Vector3.zero){
            transform.position += velocityVector * Time.deltaTime;
            good.SetActive(true);
            bad.SetActive(false);
            // Debug.LogError("Successful");
        } else {
            good.SetActive(false);
            bad.SetActive(true);
            // Debug.LogError("Unbalanced force detected.");
        }
    }
    void UpdateVelocity(){
        Vector3 accelerationVector = netForceVector / mass;
        velocityVector += accelerationVector * Time.deltaTime;
    }
    void AddForces(){
        netForceVector = Vector3.zero;

        foreach (Vector3 forceVector in forceVectorList){
            netForceVector += forceVector;
        }
    }
    // void BlinkGood(){
    //     StartCoroutine (blinkt());
    // }
    // void BlinkBad(){
    //     StartCoroutine (blinktb());
    // }
	// IEnumerator blinkt()
	// {
    //     while(true){
    //         bad.text = "";
    //         good.text = "";
    //         yield return new WaitForSeconds(2f);
    //         good.text = "Successful";
    //         yield return new WaitForSeconds(2f);
    //     }
	// }
	// IEnumerator blinktb()
	// {
    //     while(true){
    //         good.text = "";
    //         bad.text = "";
    //         yield return new WaitForSeconds(2f);
    //         bad.text = "Unbalanced Force Detected";
    //         yield return new WaitForSeconds(2f);
            
    //     }
	// }
    

    // IEnumerator blinkt()
	// {
    //     good.SetActive(true);
    //     bad.SetActive(false);
    //     yield return new WaitForSeconds (3);
    //     good.SetActive(false);
	// }
    // void BlinkTextbad()
	// {
	// 	StartCoroutine (blinktb());
    //     StopCoroutine (blinktb());
	// }
	// IEnumerator blinktb()
	// {
    //     good.SetActive(false);
    //     bad.SetActive(true);
    //     yield return new WaitForSeconds (3);
    //     bad.SetActive(false);
	// }
}   