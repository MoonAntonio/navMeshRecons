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
		public Vector3 target;

		private void Start()
		{
			navegador = GetComponent<NavMeshAgent>();

			// SetDestination ir al punto dado
			// NavMeshAgent precalcula la ruta y la ejecuta a lo largo del tiempo
		}

		public void GoToTarget()
		{
			navegador.SetDestination(target);
		}
	}
}
