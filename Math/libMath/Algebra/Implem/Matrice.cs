using System;
using Utopia.Math.Algebra.Interface;

namespace Utopia.Math.Algebra.Implem
{
	public class ClassConstraint { }

	public class Matrice<T> : ClassConstraint
	{
		private T[,] _matrice;
		private int _nbLine;
		private int _nbColonne;
		public int NbLine { get; set; }
		public int NbColonne { get; set; }

		public Matrice()
		{
			_matrice = null;
			_nbLine = 0;
			_nbColonne = 0;
		}
		public Matrice(int n)
		{
			_matrice = new T[n, n];
			_nbLine = n;
			_nbColonne = n;
		}

		public Matrice(int n, int p)
		{
			_matrice = new T[n, p];
			_nbLine = n;
			_nbColonne = p;
		}

		public Matrice(Matrice<T> originale)
		{
			int n = originale._matrice.GetLength(0);
			int p = originale._matrice.GetLength(1);
			_matrice = new T[n, p];
			_nbColonne = originale._nbColonne;
			_nbLine = originale._nbLine;
			Initialise(originale._matrice);
		}
		
		public Matrice(T[,] tableau)
		{
			int n = tableau.GetLength(0);
			int p = tableau.GetLength(1);
			_matrice = new T[n, p];
			_nbLine = n;
			_nbColonne = p;
			Initialise(tableau);
		}
        public T this[int n, int p]
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

		public IMatrice<T> Transpose
		{
			get
			{
				T[,] TableauTemporaire = new T[_nbColonne, _nbLine];

				for (int j = 0; j < _nbLine; j++)
				{
					for (int i = 0; i < _nbColonne; i++)
					{
						TableauTemporaire[i, j] = _matrice[j, i];
					}
				}
				return new Matrice<T>()TableauTemporaire);
			}

		}

		public T Determinant
		{
			get
			{
				T det = (T) Convert.ChangeType(0.0, typeof(T));

				IMatrice<T> B;

				if (_nbLine == 1)
				{
					return this[0, 0];
				}
				if (_nbLine == 2)
				{
					return this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0];
				}
				for (int j = 0; j < _nbLine; j++)
				{
					B = SousMatrice(0, j);
					if (j % 2 == 0) { det += this[0, j] * B.Determinant; }
					else { det += (T)(-1.0) * this[0, j] * B.Determinant; }
				}
				return det;
			}
		}

		public IMatrice<T> Comatrice
		{
			get
			{
				Matrice<T> B = new Matrice<T>(_nbLine, _nbColonne);
				IMatrice<T> S;

				for (int i = 0; i < B._nbColonne; i++)
				{
					for (int j = 0; j < B._nbColonne; j++)
					{
						S = SousMatrice(i, j);
						if ((i + j) % 2 == 0) { B[i, j] = S.Determinant; }
						else { B[i, j] = ((T)(-1.0) * S.Determinant); }
					}
				}
				return B;
			}
		}

		public IMatrice<T> Inverse
		{
			get
			{
				T det = Determinant;
				IMatrice<T> t_Comatrice = Comatrice.Transpose;
				IMatrice<T> Inverse = t_Comatrice.Mult (t_Comatrice, ((T)1.0) / det);
				return Inverse;
			}
		}

		public T Trace
		{
			get
			{
				T Trace = ((T)0.0);
				try
				{
					if (_nbLine == _nbColonne)
					{
						for (int i = 0; i < _nbLine; i++)
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
				if (_nbLine == _nbColonne) { return true; }
				else { return false; }
			}
		}

		public bool IsInversible
		{
			get
			{
				if (Determinant != ((T)0.0)) { return true; }
				else { return false; }
			}
		}

		public override string ToString()
		{
			string liste = "";
			for (int i = 0; i < _nbLine; i++)
			{
				liste += "|";
				for (int j = 0; j < _nbColonne; j++)
				{
					liste += "  " + _matrice[i, j];
				}
				liste += "  |\n";
			}
			return liste;
		}

		public void Initialise(T[,] tableau)
		{
			bool OK = false;
			for (int i = 0; i <= 1; i++)
			{
				if (_matrice.GetLength(0) == tableau.GetLength(0))
					OK = true;
				else
					break;
			}
			try
			{
				if (OK)
					_matrice = tableau;
				else
					throw new Exception("La dimension des données fournies ne correspond pas à la taille de la matrice.");
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
			}
		}

		public void Initialise(string NomMatrice)
		{
			Console.WriteLine("---\nInitialisation de la matrice " + NomMatrice + " ( taille = " + Length + " )");

			for (int i = 0; i < _nbLine; i++)
			{
				for (int j = 0; j < _nbColonne; j++)
				{
					Console.Write(NomMatrice + "[" + (i + 1) + "," + (j + 1) + "]=");

					this[i, j] = T.Parse(Console.ReadLine());
				}
			}
		}

		public IMatrice<T> SousMatrice(int posLine, int posColumn)
		{
			Matrice<T> matriceResult = new Matrice<T>(_nbLine - 1, _nbColonne - 1);
			int xurrentLine = 0, currentColumn = 0;
			for (int indexLine = 0; indexLine < _nbLine; indexLine++)
			{
				for (int indexColunn = 0; indexColunn < _nbColonne; indexColunn++)
				{
					if (indexLine != (posLine) && indexColunn != (posColumn))
					{
						matriceResult[xurrentLine, currentColumn] = this[indexLine, indexColunn];
						if (currentColumn < matriceResult._nbLine - 1) currentColumn++;
						else { currentColumn = 0; xurrentLine++; }
					}
				}
			}
			return matriceResult;
		}

		public IMatrice<T> Add (IMatrice<T> A, IMatrice<T> B)
		{
			Matrice<T> realA = A as Matrice<T>;
			Matrice<T> realB = B as Matrice<T>;

			try
			{
				if (A.Length == B.Length)
				{
					Matrice<T> realC = new Matrice<T>(realA._nbLine, realA._nbColonne);

					for (int i = 0; i < realA._nbLine; i++)
					{
						for (int j = 0; j < realA._nbColonne; j++)
						{
							real[i, j] = realA[i, j] + realB[i, j];
						}
					}
					return real;
				}
				else
				{
					throw new Exception("Impossible d'additionner des matrices de dimensions différentes");
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
				Matrice<T> C = new Matrice<T>(1, 1);
				return C;
			}
		}

		public IMatrice<T> Sub (IMatrice<T> A, IMatrice<T> B)
		{
			Matrice<T> realA = A as Matrice<T>;
			Matrice<T> realB = B as Matrice<T>;
			try
			{
				if (A.Length == B.Length)
				{
					IMatrice<T> C = new Matrice<T>(realA._nbLine, realA._nbColonne);
					for (int i = 0; i < realA._nbLine; i++)
					{
						for (int j = 0; j < realA._nbColonne; j++)
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
				Matrice<T> C = new Matrice<T>(1, 1);
				return C;
			}
		}

		public IMatrice<T> Mult (IMatrice<T> A, IMatrice<T> B)
		{
			Matrice<T> realA = A as Matrice<T>;
			Matrice<T> realB = B as Matrice<T>;
			try
			{
				if (realA._nbColonne == realB._nbLine)
				{
					Matrice<T> C = new Matrice<T>(realA._nbLine, realB._nbColonne);
					for (int i = 0; i < realA._nbLine; i++)
					{
						for (int j = 0; j < realB._nbColonne; j++)
						{
							for (int k = 0; k < realA._nbColonne; k++)
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
				Matrice<T> C = new Matrice<T>(1);
				return C;
			}
		}

		public IMatrice<T> Mult (T n, IMatrice<T> A)
		{
			Matrice<T> realA = A as Matrice<T>;
			Matrice<T> B = new Matrice<T>(realA);

			for (int i = 0; i < B._nbLine; i++)
			{
				for (int j = 0; j < realA._nbColonne; j++)
				{
					B[i, j] = n * realA[i, j];
				}
			}
			return B;
		}

		public IMatrice<T> Mult (IMatrice<T> A, T n)
		{
			return A.Mult(A, n);
		}
    }
}