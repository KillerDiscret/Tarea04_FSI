using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_FSI
{
    class ListaNumeros
    {
         public List<int> Numeros { get; set; }

        public ListaNumeros()
        {
            Numeros = new List<int>();
        }

        public bool VerificarInsertarNumero(int num)
        {
            return Numeros.Exists(delegate (int num2)
            {
                return num2 == num;
            });
        }

        public void InsetarNumeros(int num)
        {
            Numeros.Add(num);
        }

        public int EncontrarMayor()
        {
            int num2= 0;
            int num3;
          foreach(int x in Numeros)
            {
                num3 = x;
                if(num2<num3)
                {
                    num2 = num3;
                }
            }
            return num2;
        }
        public int EncontrarMenor()
        {
            int num2 = 9999;
            int num3;
            foreach (int x in Numeros)
            {
                num3 = x;
                if (num2 > num3)
                {
                    num2 = num3;
                }
            }
            return num2;
        }
        public void EliminarNumero(int num)
        {
            Numeros.Remove(num);
        }
        public void InsertNumero(int num,int pos)
        {
            Numeros.Insert(pos, num);
        }
        public void OrdenarNumeros()
        {
            Numeros.Sort();
        }
    }
}
