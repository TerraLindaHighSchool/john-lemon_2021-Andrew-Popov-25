using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public float amplitude = 0.2f;
    public float frequency = 0.5f;
   
    public GameObject player;

    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();

    [SerializeField] private Vector3 _rotation;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            GameObject gameEndingObject = GameObject.Find("GameEnding");
            GameEnding gameEnding = gameEndingObject.GetComponent<GameEnding>();
            gameEnding.collectedCount++;
            Debug.Log(gameEnding.collectedCount.ToString());
            gameObject.SetActive(false);
        }
    }

    void Start()
    {
        posOffset = transform.position;
    }

    void Update()
    {
        //Rotation
        transform.Rotate(_rotation * Time.deltaTime);

        //Floating
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;

        transform.position = tempPos;
    }
}
