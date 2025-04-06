using UnityEngine;

public class OnClickMove : MonoBehaviour
{
    private HingeJoint hingeJ;
    public void OnButtonClickAction()
    {
        if(hingeJ.useMotor == false) hingeJ.useMotor = true;
        else hingeJ.useMotor = false;

    }
    void Start()
    {
        hingeJ = this.GetComponent<HingeJoint>();  
    }

    
    void Update()
    {
        
    }
}
