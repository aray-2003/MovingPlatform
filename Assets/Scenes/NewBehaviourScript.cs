using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField]
        private Transform point1, point2;
        private float _speed = 3.0f;
        private bool _switch = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_switch == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, point1.position, _speed * Time.deltaTime);  
        } else if (_switch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, point2.position, _speed * Time.deltaTime);
        }
        
        if(transform.position == point1.position)
        {
            _switch = true;
        }
        else if(transform.position == point2.position)
        {
            _switch = false;
        }
    }
}
