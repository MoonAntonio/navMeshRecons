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

		private void Start()
		{
			navegador = GetComponent<NavMeshAgent>();

			// SetDestination ir al punto dado
			// NavMeshAgent precalcula la ruta y la ejecuta a lo largo del tiempo
			navegador.SetDestination(new Vector3(3.4f,0.24f,-10.27f));
		}
	}
}
