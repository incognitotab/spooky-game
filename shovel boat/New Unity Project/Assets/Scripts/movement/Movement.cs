using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum MovementType
{
    Walking,
    Boat,
}
public class Movement : MonoBehaviour
{
    Vector2 Move, Rot, Saverot = Vector2.zero;
    Vector3 InputPos,InputRotation;
    [SerializeField] float Speed = 5;
    [SerializeField] float MomentumSpeed = 6;
    [SerializeField] float RotationAmount = 0;
    [SerializeField] bool Looking,Rotating,Rowing,Rowed;
    Rigidbody Rb;
    public MovementType Trav;
    

    // Start is called before the first frame update
    void Start()
    {
        registerinput();
        Rb = GetComponent<Rigidbody>();
        Rowing = true;
    }

    void registerinput()
    {
        #region Moveperf
        InputManager.Minput.pinput.Controllerandkeyboard.Movement.performed += ctx =>
        {
            if (Trav == MovementType.Walking)
            {
                Move = ctx.ReadValue<Vector2>();
                Rotating = true;

                if (!Looking && Move != Vector2.zero)
                {

                    Rot = ctx.ReadValue<Vector2>();
                    //Saverot = Rot;
                }

                else
                {
                    Rotating = false;
                }
                return;
            }

            if(Trav == MovementType.Boat)
            {
                Rot = ctx.ReadValue<Vector2>();
                Rotating = true;
            }
        };

        InputManager.Minput.pinput.Controllerandkeyboard.Lookaction.performed += ctx =>
        {
            if (Trav == MovementType.Walking)
            {
                Rotating = true;
                if (Vector2.Distance(Saverot, ctx.ReadValue<Vector2>()) > 0.1f)
                {
                    Looking = true;
                    Rot = (ctx.ReadValue<Vector2>() - (Vector2)transform.position).normalized;
                    Saverot = ctx.ReadValue<Vector2>();


                }

                Looking = false;
            }
        };

        InputManager.Minput.pinput.Controllerandkeyboard.attack.performed += ctx =>
         {
             if (Trav == MovementType.Boat)
             {

                 Rb.AddForce(transform.forward*MomentumSpeed, ForceMode.VelocityChange);

                 MomentumSpeed = 0;
                 StartCoroutine(BoatMomentum());
             }
         };


        #endregion
       

       

        #region Movecan

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        InputPos = new Vector3(Vector3.forward.x * Move.y, 0, Vector3.forward.z * Move.y);
        InputPos += new Vector3(Vector3.right.x * Move.x, 0, Vector3.right.z * Move.x);

       
        InputRotation = Rot;
            
        

       

      
        Debug.Log(Rot);
    }

    void FixedUpdate()
    {
        if (Trav == MovementType.Walking)
        {
            if (Rotating == true)
            {
                Rb.rotation = Quaternion.Lerp(Rb.rotation, Quaternion.LookRotation(new Vector3(InputRotation.x, 0, InputRotation.y), Vector3.up), 10 * Time.deltaTime);
            }
            Rb.MovePosition(Rb.position + (InputPos * Speed * Time.deltaTime));
            return;
        }

        if (Rotating == true)
        {
            RotationAmount += Rot.x;
            Rb.rotation = Quaternion.Lerp(Rb.rotation, Quaternion.Euler(0,RotationAmount, 0), 15 * Time.deltaTime);
        }

    }

    IEnumerator BoatMomentum()
    {
        if (Rowing)
        {
            Rowing = false;
            yield return new WaitForSecondsRealtime(0.4f);
            
            while (MomentumSpeed <= 4 )
            {
                MomentumSpeed +=3*Time.deltaTime;
                yield return null;
            }
            

            Rowing = true;
            
        }
        yield break;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + (transform.forward * 10));
    }
}
