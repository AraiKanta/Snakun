using System;
using UnityEngine;


namespace UnityStandardAssets.Utility
{
    public class FollowTarget : MonoBehaviour
    {
        public Transform target;
        public Vector3 offset = new Vector3(0f, 7.5f, 0f);

		void Start()
		{
			target = GameObject.FindGameObjectWithTag ("Player").transform;	
		}
        private void LateUpdate()
        {
            if(target != null)
            transform.position = new Vector3(0,target.position.y + offset.y,target.position.z + offset.z);
        }
    }
}
