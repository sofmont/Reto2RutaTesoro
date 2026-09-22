using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto2RutaTesoro
{
    internal class ListaSimple
    {
        public Nodo Inicio { get; private set; }

        public ListaSimple()
        {
            Inicio = null;
        }

        // Inserción ordenada por ID (de menor a mayor)
        public bool Insertar(int id, string nombre, string pista, int nivelPeligro)
        {
            // Validar que el ID no exista
            if (Buscar(id) != null)
                return false;

            Nodo nuevo = new Nodo(id, nombre, pista, nivelPeligro);

            // Caso 1: La lista está vacía o el nuevo ID es menor que el del primer nodo
            if (Inicio == null || id < Inicio.Id)
            {
                nuevo.Siguiente = Inicio;
                Inicio = nuevo;
                return true;
            }

            // Caso 2: Buscar la posición correcta en el medio o al final
            Nodo actual = Inicio;
            while (actual.Siguiente != null && actual.Siguiente.Id < id)
            {
                actual = actual.Siguiente;
            }

            nuevo.Siguiente = actual.Siguiente;
            actual.Siguiente = nuevo;
            return true;
        }

        public Nodo Buscar(int id)
        {
            Nodo actual = Inicio;
            while (actual != null)
            {
                if (actual.Id == id)
                    return actual;

                // Si encontramos un ID mayor, significa que ya no existe (por estar ordenada)
                if (actual.Id > id)
                    break;

                actual = actual.Siguiente;
            }
            return null;
        }

        public bool Modificar(int id, string nuevoNombre, string nuevaPista, int nuevoNivelPeligro)
        {
            Nodo nodo = Buscar(id);
            if (nodo != null)
            {
                nodo.Nombre = nuevoNombre;
                nodo.Pista = nuevaPista;
                nodo.NivelPeligro = nuevoNivelPeligro;
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            if (Inicio == null)
                return false;

            if (Inicio.Id == id)
            {
                Inicio = Inicio.Siguiente;
                return true;
            }

            Nodo actual = Inicio;
            while (actual.Siguiente != null)
            {
                if (actual.Siguiente.Id == id)
                {
                    actual.Siguiente = actual.Siguiente.Siguiente;
                    return true;
                }

                // Si el ID del siguiente nodo es mayor al buscado, no existe
                if (actual.Siguiente.Id > id)
                    break;

                actual = actual.Siguiente;
            }
            return false;
        }
    }
}
