using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadBehavior : MonoBehaviour
{

    private Vector3 _positionRepeat;
    private Vector3 _positionDelta;

    [SerializeField] float _roadSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _positionRepeat = new Vector3(0, 0, -300);
        _positionDelta = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        RoadRepeat();
    }


    public void RoadRepeat() {
        if (transform.position.z > 0)
        {
            transform.position = _positionRepeat;
        }
        else
        {
            transform.position += _positionDelta * _roadSpeed * Time.deltaTime ;
        }
    }
}
