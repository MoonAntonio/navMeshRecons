using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPatrol : MonoBehaviour {

	public NavMeshAgent navegador;

	public Transform[] patrolPoint;

	public int currentPatrolPoint;

	public float idleTime = 1.5f;

	private void Start()
	{
		// Asignamos los componentes
		navegador = GetComponent<NavMeshAgent>();

		// Inicializamos la patrulla
		currentPatrolPoint = -1;
		GoToNextPatrolPoint();
	}

	private void Update()
	{
		// Cuando llegas al punto
		if(navegador.remainingDistance < 0.5f)
		{
			// Si no esta invocando el metodo, invocarlo
			if(!IsInvoking("GoToNextPatrolPoint")) Invoke("GoToNextPatrolPoint",idleTime);
		} 
	}

	private void GoToNextPatrolPoint()
	{
		// Aumentamos el punto general
		currentPatrolPoint++;

		// Comprobamos si el punto esta en el array
		if(currentPatrolPoint >= patrolPoint.Length) currentPatrolPoint = 0;

		// Movemos hacia el punto
		navegador.SetDestination(patrolPoint[currentPatrolPoint].position);
	}
}
