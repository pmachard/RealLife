using System;
using Utopia.Math.Algebra.Interface;

namespace Utopia.Math.Algebra.Implem
{
	public class Matrice : IMatrice
	{
		private float[,] _matrice;
		private int _nbLignes;
		private int _nbColonnes;

		public Matrice(int n, int p)
		{
			this._matrice = new float[n, p];
			this._nbLignes = n;
			this._nbColonnes = p;
		}

		public Matrice(Matrice originale)
		{
			int n = originale._matrice.GetLength(0);
			int p = originale._matrice.GetLength(1);
			this._matrice = new float[n, p];
			this._nbColonnes = originale._nbColonnes;
			this._nbLignes = originale._nbLignes;
			Initialise(originale._matrice);
		}

		public Matrice(float[,] tableau)
		{
			int n = tableau.GetLength(0);
			int p = tableau.GetLength(1);
			this._matrice = new float[n, p];
			this._nbLignes = n;
			this._nbColonnes = p;
			Initialise(tableau);
		}

		public Matrice(int n)
		{
			this._matrice = new float[n, n];
			this._nbLignes = n;
			this._nbColonnes = n;
		}

		public float this[int n, int p]
		{
			get { return _matrice[n, p]; }
			set { _matrice[n, p] = value; }
		}

		public string Length
		{
			get
			{
				int n = _matrice.GetLength(0);
				int p = _matrice.GetLength(1);
				string length = "(" + n + "," + p + ")";
				return length;
			}
		}

		public IMatrice Transpose
		{
			get
			{
				float[,] TableauTemporaire = new float[_nbColonnes, _nbLignes];

				for (int j = 0; j < _nbLignes; j++)
				{
					for (int i = 0; i < _nbColonnes; i++)
					{
						TableauTemporaire[i, j] = _matrice[j, i];
					}
				}
				return new Matrice(TableauTemporaire);
			}

		}

		public float Determinant
		{
			get
			{
				float det = 0;
				IMatrice B;

				if (this._nbLignes == 1) return this[0, 0];
				if (this._nbLignes == 2) return (this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0]);

				for (int j = 0; j < this._nbLignes; j++)
				{
					B = this.SousMatrice(0, j);
					if (j % 2 == 0) { det += this[0, j] * B.Determinant; }
					else { det += -1 * this[0, j] * B.Determinant; }
				}
				return det;
			}
		}

		public IMatrice Comatrice
		{
			get
			{
				Matrice B = new Matrice(this._nbLignes, this._nbColonnes);
				IMatrice S;

				for (int i = 0; i < B._nbColonnes; i++)
				{
					for (int j = 0; j < B._nbColonnes; j++)
					{
						S = this.SousMatrice(i, j);
						if ((i + j) % 2 == 0) { B[i, j] = S.Determinant; }
						else { B[i, j] = -1 * S.Determinant; }
					}
				}
				return B;
			}
		}

		public IMatrice Inverse
		{
			get
			{
				float det = this.Determinant;
				IMatrice t_Comatrice = this.Comatrice.Transpose;
				IMatrice Inverse = t_Comatrice.Mult (t_Comatrice,1 / det);
				return Inverse;
			}
		}

		public float Trace
		{
			get
			{
				float Trace = 0;
				try
				{
					if (this._nbLignes == this._nbColonnes)
					{
						for (int i = 0; i < this._nbLignes; i++)
						{
							Trace += this[i, i];
						}
						return Trace;
					}
					else
					{
						throw new Exception("Impossible de calculer la trace du matrice non carrée");
					}
				}
				catch (Exception e)
				{
					Console.Error.WriteLine("" + e);
					return Trace;
				}
			}
		}

		public bool IsCarree
		{
			get
			{
				if (this._nbLignes == this._nbColonnes) { return true; }
				else { return false; }
			}
		}

		public bool IsInversible
		{
			get
			{
				if (this.Determinant != 0) { return true; }
				else { return false; }
			}
		}

		public override string ToString()
		{
			string liste = "";
			for (int i = 0; i < _nbLignes; i++)
			{
				liste += "|";
				for (int j = 0; j < _nbColonnes; j++)
				{
					liste += "  " + _matrice[i, j];
				}
				liste += "  |\n";
			}
			return liste;
		}

		public void Initialise(float[,] tableau)
		{
			bool OK = false;
			for (int i = 0; i <= 1; i++)
			{
				if (this._matrice.GetLength(0) == tableau.GetLength(0))
				{
					OK = true;
				}
				else
				{
					break;
				}
			}
			try
			{
				if (OK)
				{
					_matrice = tableau;
				}
				else
				{
					throw new Exception("La dimension des données fournies ne correspond pas à la taille de la matrice.");
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
			}
		}

		public void Initialise(string NomMatrice)
		{
			Console.WriteLine("---\nInitialisation de la matrice " + NomMatrice + " ( taille = " + this.Length + " )");

			for (int i = 0; i < this._nbLignes; i++)
			{
				for (int j = 0; j < this._nbColonnes; j++)
				{
					Console.Write(NomMatrice + "[" + (i + 1) + "," + (j + 1) + "]=");

					this[i, j] = float.Parse(Console.ReadLine());
				}
			}
		}

		public IMatrice SousMatrice(int posLine, int posColumn)
		{
			Matrice matriceResult = new Matrice(this._nbLignes - 1, this._nbColonnes - 1);
			int xurrentLine = 0, currentColumn = 0;
			for (int indexLine = 0; indexLine < this._nbLignes; indexLine++)
			{
				for (int indexColunn = 0; indexColunn < this._nbColonnes; indexColunn++)
				{
					if (indexLine != (posLine) && indexColunn != (posColumn))
					{
						matriceResult[xurrentLine, currentColumn] = this[indexLine, indexColunn];
						if (currentColumn < matriceResult._nbLignes - 1) currentColumn++;
						else { currentColumn = 0; xurrentLine++; }
					}
				}
			}
			return matriceResult;
		}

		public IMatrice Add (IMatrice A, IMatrice B)
		{
			Matrice realA = A as Matrice;
			Matrice realB = B as Matrice;

			try
			{
				if (A.Length == B.Length)
				{
					Matrice C = new Matrice(realA._nbLignes, realA._nbColonnes);
					for (int i = 0; i < realA._nbLignes; i++)
					{
						for (int j = 0; j < realA._nbColonnes; j++)
						{
							C[i, j] = realA[i, j] + realB[i, j];
						}
					}
					return C;
				}
				else
				{
					throw new Exception("Impossible d'additionner des matrices de dimensions différentes");
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
				Matrice C = new Matrice(1, 1);
				return C;
			}
		}

		public IMatrice Sub (IMatrice A, IMatrice B)
		{
			Matrice realA = A as Matrice;
			Matrice realB = B as Matrice;
			try
			{
				if (A.Length == B.Length)
				{
					Matrice C = new Matrice(realA._nbLignes, realA._nbColonnes);
					for (int i = 0; i < realA._nbLignes; i++)
					{
						for (int j = 0; j < realA._nbColonnes; j++)
						{
							C[i, j] = realA[i, j] - realB[i, j];
						}
					}
					return C;
				}
				else
				{
					throw new Exception("Impossible de soustraire des matrices de dimensions différentes");
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
				Matrice C = new Matrice(1, 1);
				return C;
			}
		}

		public IMatrice Mult (IMatrice A, IMatrice B)
		{
			Matrice realA = A as Matrice;
			Matrice realB = B as Matrice;
			try
			{
				if (realA._nbColonnes == realB._nbLignes)
				{
					Matrice C = new Matrice(realA._nbLignes, realB._nbColonnes);
					for (int i = 0; i < realA._nbLignes; i++)
					{
						for (int j = 0; j < realB._nbColonnes; j++)
						{
							for (int k = 0; k < realA._nbColonnes; k++)
							{
								C[i, j] += realA[i, k] * realB[k, j];
							}
						}
					}
					return C;
				}
				else
				{
					throw new Exception("Impossible de multiplier les matrices, les dimensions ne correspondent pas");
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
				Matrice C = new Matrice(1);
				return C;
			}
		}

		public IMatrice Mult (float n, IMatrice A)
		{
			Matrice realA = A as Matrice;
			Matrice B = new Matrice(realA);

			for (int i = 0; i < B._nbLignes; i++)
			{
				for (int j = 0; j < realA._nbColonnes; j++)
				{
					B[i, j] = n * realA[i, j];
				}
			}
			return B;
		}

		public IMatrice Mult (IMatrice A, float n)
		{
			IMatrice B;
			B = A.Mult (A,n);
			return B;
		}

    }
}