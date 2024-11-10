using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float mass;
    public float massMax;
    public float massUP;
    public float Speed;
    public float SpeedDown;
    public float CameraSize;
    public float CameraSizeMax;

    [SerializeField] private LoadSaveScript LoadSaveScript;
    [SerializeField] private Events EventsScript;
    private PlayerStats PlayerStatsScript;
    [SerializeField] private Camera Main_Cam;
    private MobileControler mContr;
    private Vector2 PlayerVector;
    private Vector2 RandVector;
    private Vector3 VecScale;

    void Start()
    {
        massUP += LoadSaveScript.ShopCl.Mass_Eat_Lvl * 0.0001f;
        Speed += LoadSaveScript.ShopCl.Speed_Pl_Lvl * 0.1f;
        VecScale.Set(mass, mass, mass);
        mContr = GameObject.FindWithTag("Joystick").GetComponent<MobileControler>();
        PlayerStatsScript = gameObject.GetComponent<PlayerStats>();
    }
    private void Update()
    {
        if (mass < massMax)
            mass += 0.001f;
        if (mass > massMax)
            mass = massMax;
        if (CameraSize < CameraSizeMax)
            CameraSize += 0.005f;
        if (CameraSize > CameraSizeMax)
            CameraSize = CameraSizeMax;
        PlayerStatsScript = gameObject.GetComponent<PlayerStats>();
        VecScale.Set(mass, mass, mass);
        transform.localScale = VecScale;
        Main_Cam.orthographicSize = CameraSize;

        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        PlayerVector = moveInput.normalized * (Speed - SpeedDown);
        PlayerVector.x = mContr.Horizontal() * (Speed - SpeedDown);
        PlayerVector.y = mContr.Vertical() * (Speed - SpeedDown);

    }
    private void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody2D>().MovePosition(gameObject.GetComponent<Rigidbody2D>().position + PlayerVector * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Eat")
        {
            PlayerStatsScript.mass_int_lvl += massUP;
            RandVector.Set(Random.Range(-99.5f, 99.5f), Random.Range(-99.5f, 99.5f));
            col.gameObject.transform.position = RandVector;
        }
        if (col.tag == "DeadZone")
        {
            EventsScript.Dead();
        }
    }
}
