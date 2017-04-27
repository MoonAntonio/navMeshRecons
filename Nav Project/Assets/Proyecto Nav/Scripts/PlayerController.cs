using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace MoonAntonio
{
	public class PlayerController : MonoBehaviour 
	{
		// Componentes
		public NavMeshAgent navegador;
		public Transform target;

		private void Start()
		{
			navegador = GetComponent<NavMeshAgent>();
			target = GameObject.FindGameObjectWithTag("Target").transform;

			// SetDestination ir al punto dado
			// NavMeshAgent precalcula la ruta y la ejecuta a lo largo del tiempo

			if(target) navegador.SetDestination(target.position);
		}
	}
}
