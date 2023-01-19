using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float speed = 30f;

    private GameObject pivot;
    // Start is called before the first frame update
    void Start()
    {
        pivot = GameObject.Find("PivotPoint");
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("RingRotationPeriod");
    }
    IEnumerator RingRotationPeriod()
    {
        RingRotationDown();
        yield return new WaitForSeconds(Random.Range(1, 5));
        RingRotationUp();
    }
    private void RingRotationDown()
    {
        pivot.transform.Rotate(Vector3.down * speed * Time.deltaTime);
    }

    private void RingRotationUp()
    {
        pivot.transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
