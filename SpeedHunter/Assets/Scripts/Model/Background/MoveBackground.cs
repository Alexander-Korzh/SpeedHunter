
using UnityEngine;


public class MoveBackground : MonoBehaviour 
{

    #region Fields

    [SerializeField] private float speed;
	[SerializeField] private float endPositionX;
	
	private Vector3 step;
	private Vector3 endPosition;

	#endregion

	#region Methods

	public void Start () 
	{
		step = new Vector3();

		endPosition = new Vector3(-endPositionX, 0, transform.localPosition.z);
	}

	public void Update () 
	{
		step.x = speed * Time.deltaTime;

		transform.localPosition += step;

		if (transform.localPosition.x <= endPositionX) 
			
			transform.localPosition = endPosition;
	}

    #endregion

}
