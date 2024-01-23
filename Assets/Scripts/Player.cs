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
            // Touch �ν��Ͻ� ����
            Touch touch = Input.GetTouch(0);

            // ��ġ�� �� ����
            if (touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }
        }

        /*
         * ������ ������ �ӵ��� ������ �����ʰ� �����̱� ���ؼ�
         * Time.deltaTime�� ���Ѵ�.
         * �ش� ���� ���� ���������κ��� ���� �ð��� ��ȯ�Ѵ�.
         * �߷��� ���ӵ��� �ٱ� ������ �ش� ���� �� �� ���Ѵ�.
         */
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
}
