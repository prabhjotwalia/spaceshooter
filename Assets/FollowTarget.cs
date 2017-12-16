using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    Transform mTarget;
    [SerializeField]
    float mFollowSpeed;
    [SerializeField]
    float mFollowRange;

    float mArriveThreshold = 0.05f;

    void Update()
    {
        if (mTarget != null)
        {

            Vector3 realTargetPosition = new Vector3(mTarget.transform.position.x, mTarget.transform.position.y, transform.position.z);
            float distance = Vector2.Distance(realTargetPosition, transform.position);
            if (distance < mFollowRange)
            {
                Vector3 targetPositionX = new Vector3(mTarget.transform.position.x, transform.position.y, transform.position.z);
                Vector3 direction = targetPositionX - transform.position;

                transform.Translate(direction.normalized * mFollowSpeed * Time.deltaTime);
            }
        }
    }

    public void SetTarget(Transform target)
    {
        mTarget = target;
    }
}