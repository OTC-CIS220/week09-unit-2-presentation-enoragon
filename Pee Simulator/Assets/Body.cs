using System.Collections;
using UnityEngine;

public class Body : MonoBehaviour {
    public float speed = 0.1f;
    public float edgeBounds = 1f;
    public float waitTime = 5f;

    private float startPos;
    private float leftEdge;
    private float rightEdge;

    private IEnumerator coroutine;
    // Use this for initialization
    void Start () {
        startPos = transform.position.x;
        leftEdge = startPos + edgeBounds;
        rightEdge = startPos - edgeBounds;
        coroutine = Shimmy();
        StartCoroutine(coroutine);
    }
	
	// Update is called once per frame
	void Update () {

    }

    IEnumerator Shimmy()
    {
        while (true)
        {
            Vector3 target = new Vector3(Random.Range(leftEdge, rightEdge), transform.position.y, transform.position.z);
            while (transform.position != target)
            {
                transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
                yield return null;
            }
            yield return new WaitForSeconds(Random.Range(0,waitTime));

        }

    }
}
