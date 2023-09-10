using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.Modelo
{
    class Persona
    {
        private String nombre;
        private int edad;
        private String sexo;
        private double altura;
        private double peso;
        private string DNI;

        public Persona() //Primer contructor
        {

            this.nombre = "";
            this.edad = 0;
            this.sexo = "H";
            this.peso = 0.0;
            this.altura = 0.0;
            comprobarSexo(sexo);
        }
        public Persona(String nombre, int edad, String sexo)//Segundo contructor
        {
            //El nombre de la derecha es el que llega como parametro
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0.0;
            this.altura = 0.0;
            generarDNI();
            comprobarSexo(sexo);
        }

        //Tercer constructor
        public Persona(String nombre, int edad, String sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
            generarDNI();
            comprobarSexo(sexo);
        }

        //Creando metodo con parametros y que retorne un numero
        public int calcularIMC(double peso, double altura)
        {
            int respuestaRetorno;
            double imc;

            imc = peso / (Math.Pow(altura, 2));

            if (imc < 20)
            {
                respuestaRetorno = -1;
            }
            else if (imc >= 20 && imc <= 25)
            {
                respuestaRetorno = 0;
            }
            else
            {
                respuestaRetorno = 1;
            }

            return respuestaRetorno;
        }

        //Segundo metodo, bool que comprueba si es Mayor de edad
        public bool esMayorEdad(int edad)
        {
            //If el parametoro entra en el if, retorna true y hasta ahi llega el codigo
            if (edad >= 18)
            {
                return true;
            }
            return false;

        }

        //Metodo privado 
        private void comprobarSexo(String sexo)
        {
            if (sexo.Equals("H") || sexo.Equals("M"))
            {
                this.sexo = sexo;
            }
            else
            {
                this.sexo = "H";
            }
        }

        public override string ToString()
        {
            return $"Nombre -> {this.nombre} , " +
                $"edad -> {this.edad}, sexo -> {this.sexo}, " +
                $"peso -> {this.peso}, altura -> {this.altura}" +
                $"DNI - >{this.DNI}";
        }

        private void generarDNI()
        {
            Random rnd = new Random();
            //this.DNI = rnd.Next(10000000, 99999999).ToString();
            for(int i = 0; i <8; i++)
            {
                this.DNI += rnd.Next(0, 10);
            }
            char[] letra = this.nombre.ToCharArray();

            this.DNI = letra[0] + this.DNI;
        }
    }
}
