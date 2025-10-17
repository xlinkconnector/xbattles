using UnityEngine;
public class SwordController : MonoBehaviour {
    void Update() {
        if (Input.GetMouseButtonDown(0)) Slash();
    }
    void Slash() {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, 2f)) {
            hit.rigidbody.AddForce(Vector3.up * 500);
            // BLOOD FOUNTAIN
            Instantiate(Resources.Load("BloodSpray"), hit.point, Quaternion.identity);
        }
    }
}
