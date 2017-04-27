using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IAPatrol : MonoBehaviour {

	public NavMeshAgent navegador;

	public Transform[] patrolPoint;

	public int currentPatrolPoint;

	private void Start()
	{
		// Asignamos los componentes
		navegador = GetComponent<NavMeshAgent>();

		// Inicializamos la patrulla
		currentPatrolPoint = -1;
		GoToNextPatrolPoint();
	}

	private void GoToNextPatrolPoint()
	{
		currentPatrolPoint++;

		if(currentPatrolPoint >= patrolPoint.Length) currentPatrolPoint = 0;

		navegador.SetDestination(patrolPoint[currentPatrolPoint].position);
	}
}
