using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio01
{
    class Veiculo
    {
		private int id;
		private string placa;
		private int anoModelo;
		private string marca;
		private string cor;
		private string modelo;
		private double valor;

		public Veiculo()
		{
		}

		public Veiculo(int id,string placa, int anoModelo, string marca, string cor, string modelo, double valor)
		{
			this.id = id;
			this.placa = placa;
			this.anoModelo = anoModelo;
			this.marca = marca;
			this.cor = cor;
			this.modelo = modelo;
			this.valor = valor;
		}

		public string Placa { get => placa; set => placa = value; }
		public int AnoModelo { get => anoModelo; set => anoModelo = value; }
		public string Marca { get => marca; set => marca = value; }
		public string Cor { get => cor; set => cor = value; }
		public string Modelo { get => modelo; set => modelo = value; }
		public double Valor { get => valor; set => valor = value; }
		public int Id { get => id; set => id = value; }
	}
}
