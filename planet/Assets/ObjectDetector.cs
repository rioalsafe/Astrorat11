using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{

    public GameObject turret;

    Camera mainCamera;
    RectTransform rectTransform;
    Vector2 targetPosition;
    RaycastHit2D hit;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            Debug.Log("Ŭ������ǥ" + worldPoint);
            Debug.Log(hit.collider);

            //��ž����
            Instantiate(turret, worldPoint, Quaternion.identity);
        }
    }
}
