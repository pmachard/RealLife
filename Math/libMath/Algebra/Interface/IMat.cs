using System;

namespace Utopia.Math.Algebra.Interface
{
	public interface IMat 
	{
		void Initialise(double[,] tableau);
		void Initialise(string NomMatrice);

		int Length { get;  }

		int NbLine { get; set; }
		int NbColonne { get; set; }

		string ToString();
		double Trace { get; }

		bool IsCarree { get; }	
		bool IsInversible { get; }

		IMat SousMatrice(int ib, int jb);
		IMat Add(IMat A, IMat B);
		IMat Sub(IMat A, IMat B);

		IMat Transpose { get; }
		double Determinant {get; }
		IMat Comatrice { get; }
		IMat Mult(IMat A, IMat B);
		IMat Mult(IMat A,double n);
		IMat Inverse { get; }

		bool CompareInf(IMat left, IMat right);
		bool CompareSub(IMat left, IMat right);
		bool CompareInfEqual(IMat left, IMat right);
		bool CompareSubEqual(IMat left, IMat right);

    }
}