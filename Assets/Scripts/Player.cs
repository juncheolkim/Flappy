using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            direction = Vector3.up * strength;
        }
        if(Input.touchCount > 0)
        {
            // Touch 인스턴스 생성
            Touch touch = Input.GetTouch(0);

            // 터치를 한 순간
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        /*
         * 게임의 프레임 속도에 영향을 받지않고 움직이기 위해서
         * Time.deltaTime을 곱한다.
         * 해당 값은 직전 프레임으로부터 지난 시간을 반환한다.
         * 중량은 가속도가 붙기 때문에 해당 값을 두 번 곱한다.
         */
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
