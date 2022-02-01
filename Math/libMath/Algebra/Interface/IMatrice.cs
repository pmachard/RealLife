using System;
using System.Collections.Generic;
using System.Text;

namespace Utopia.Math.Algebra.Interface
{
	public interface IMatrice
	{
		void Initialise(float[,] tableau);
		void Initialise(string NomMatrice);

		string Length { get;  }
		string ToString();
		float Trace { get; }

		bool IsCarree { get; }
		bool IsInversible { get; }

		IMatrice SousMatrice(int ib, int jb);
		IMatrice Add(IMatrice A, IMatrice B);
		IMatrice Sub(IMatrice A, IMatrice B);

		IMatrice Transpose { get; }
		float Determinant {get; }
		IMatrice Comatrice { get; }
		IMatrice Mult(IMatrice A, IMatrice B);
		IMatrice Mult(float n, IMatrice A);
		IMatrice Mult(IMatrice A, float n);
		IMatrice Inverse { get; }
	}
}