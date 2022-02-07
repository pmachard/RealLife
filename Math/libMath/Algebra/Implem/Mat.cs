using System;
using System.Diagnostics.CodeAnalysis;
using Utopia.Math.Algebra.Interface;

namespace Utopia.Math.Algebra.Implem
{

    public class Mat : IMat
	{
		private double[,] _matrice;
		private int _nbLine;
		private int _nbColonne;
		public int NbLine 
		{
			get { return _nbLine; } 
			set { _nbLine = value; }
		}
		public int NbColonne 
		{
			get { return _nbColonne; }
			set { _nbColonne = value; }
		}

		public Mat()
		{
			_matrice = null;
			NbLine = 0;
			NbColonne = 0;
		}
		public Mat(int n)
		{
			_matrice = new double[n, n];
			_nbLine = n;
			_nbColonne = n;
		}
		public Mat(int n, int p)
		{
			_matrice = new double[n, p];
			_nbLine = n;
			_nbColonne = p;
		}
		public Mat(Mat originale)
		{
			int n = originale._matrice.GetLength(0);
			int p = originale._matrice.GetLength(1);
			_matrice = new double[n, p];
			_nbColonne = originale._nbColonne;
			_nbLine = originale._nbLine;
			Init(originale._matrice);
		}
		public Mat(double[,] tableau)
		{
			int n = tableau.GetLength(0);
			int p = tableau.GetLength(1);
			_matrice = new double[n, p];
			_nbLine = n;
			_nbColonne = p;
			Init(tableau);
		}

        public double this[int n, int p]
		{
			get { return _matrice[n, p]; }
			set { _matrice[n, p] = value; }
		}

		public int Length
		{
			get
			{
				return NbLine * NbColonne;  
			}
		}

		public IMat Transpose
		{
			get
			{
				double[,] TableauTemporaire = new double[_nbColonne, _nbLine];
				for (int j = 0; j < _nbLine; j++)
					for (int i = 0; i < _nbColonne; i++)
						TableauTemporaire[i, j] = _matrice[j, i];

				return new Mat (TableauTemporaire);
			}
		}

		public double Determinant
		{
			get
			{
				double det = 0.0;
				IMat B;

				if (_nbLine == 1)
				{
					return this[0, 0];
				}
				if (_nbLine == 2)
				{
					return (this[0, 0] * this[1, 1] - this[0, 1] * this[1, 0]);
				}
				for (int j = 0; j < _nbLine; j++)
				{
					B = SubMat(0, j);
					if (j % 2 == 0) { det += this[0, j] * B.Determinant; }
					else { det += this[0, j] * B.Determinant; }
				}
				return det;
			}
		}

		public IMat Comatrice
		{
			get
			{
				Mat B = new Mat(_nbLine, _nbColonne);
				IMat S;

				for (int i = 0; i < B._nbColonne; i++)
					for (int j = 0; j < B._nbColonne; j++)
					{
						S = SubMat(i, j);
						if ((i + j) % 2 == 0) { B[i, j] = S.Determinant; }
						else { B[i, j] = -1.0 * S.Determinant; }
					}

				return B;
			}
		}


		public double Trace
		{
			get
			{
				double Trace = 0.0;
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
				if (Determinant != 0.0) { return true; }
				else { return false; }
			}
		}

        public IMat Inverse => throw new NotImplementedException();

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

		public void Init(double[,] tableau)
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

		public void Init(string NomMatrice)
		{
			Console.WriteLine("---\nInitialisation de la matrice " + NomMatrice + " ( taille = " + Length + " )");

			for (int i = 0; i < _nbLine; i++)
			{
				for (int j = 0; j < _nbColonne; j++)
				{
					Console.Write(NomMatrice + "[" + (i + 1) + "," + (j + 1) + "]=");

					this[i, j] = double.Parse(Console.ReadLine());
				}
			}
		}

		public IMat SubMat(int posLine, int posColumn)
		{
			Mat result = new Mat(NbLine - 1, NbColonne - 1);
			int xurrentLine = 0, currentColumn = 0;
			for (int indexLine = 0; indexLine < _nbLine; indexLine++)
			{
				for (int indexColunn = 0; indexColunn < _nbColonne; indexColunn++)
				{
					if (indexLine != (posLine) && indexColunn != (posColumn))
					{
						result[xurrentLine, currentColumn] = this[indexLine, indexColunn];
						if (currentColumn < result.NbLine - 1) currentColumn++;
						else { currentColumn = 0; xurrentLine++; }
					}
				}
			}
			return result;
		}

		public IMat Add (IMat aMat, IMat bMat)
		{
			try
			{

				Mat localAMat = aMat as Mat;
				Mat localBMat = bMat as Mat;

				if (localAMat.Length == localBMat.Length)
				{
					Mat c = new Mat(localAMat.NbLine, localBMat.NbColonne);

					for (int i = 0; i < localAMat.NbLine; i++)
					{
						for (int j = 0; j < localAMat.NbColonne; j++)
						{
							c[i, j] = localAMat[i, j] + localBMat[i, j];
						}
					}
					return c;
				}
				else
				{
					throw new Exception("Impossible d'additionner des matrices de dimensions différentes");
				}
			}
			catch (Exception e)
			{
				Console.Error.WriteLine("" + e);
				return new Mat(1, 1);
			}
		}

		public IMat Sub (IMat A, IMat B)
		{
			Mat realA = A as Mat;
			Mat realB = B as Mat;
			try
			{
				if (A.Length == B.Length)
				{
					Mat C = new Mat(realA._nbLine, realA._nbColonne);
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
				Mat C = new Mat(1, 1);
				return C;
			}
		}

		public IMat Mult (IMat A, IMat B)
		{
			Mat realA = A as Mat;
			Mat realB = B as Mat;
			try
			{
				if (realA._nbColonne == realB._nbLine)
				{
					Mat C = new Mat(realA._nbLine, realB._nbColonne);
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
				Mat C = new Mat(1);
				return C;
			}
		}

		public IMat Mult(double n, IMat A)
		{
			Mat realA = A as Mat;
			Mat B = new Mat(realA);

			for (int i = 0; i < B._nbLine; i++)
			{
				for (int j = 0; j < realA._nbColonne; j++)
				{
					B[i, j] = n * realA[i, j];
				}
			}
			return B;
		}

		public IMat Mult(IMat matriceA, double value)
		{
			return Mult(value, matriceA);
		}

        public void Initialise(double [,] tableau)
        {
            throw new NotImplementedException();
        }

        public void Initialise(string NomMatrice)
        {
            throw new NotImplementedException();
        }

        public bool CompareInf(IMat left, IMat right)
        {
			return left.Length < right.Length;
		}

        public bool CompareSub(IMat left, IMat right)
        {
			return left.Length > right.Length;
		}

		public bool CompareInfEqual(IMat left, IMat right)
        {
			return left.Length <= right.Length;
		}

		public bool CompareSubEqual(IMat left, IMat right)
		{
			return (left.Length >= right.Length);
		}

        public IMat SousMatrice(int ib, int jb)
        {
            throw new NotImplementedException();
        }
    }
}