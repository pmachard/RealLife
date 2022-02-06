using System;
using System.Collections.Generic;
using System.Text;

namespace Utopia.Math.Algebra.Interface
{
	public interface IMatrice<T> 
	{
		void Initialise(T[,] tableau);
		void Initialise(string NomMatrice);

		string Length { get;  }
		string ToString();
		T Trace { get; }

		bool IsCarree { get; }
		bool IsInversible { get; }

		IMatrice<T> SousMatrice(int ib, int jb);
		IMatrice<T> Add(IMatrice<T> A, IMatrice<T> B);
		IMatrice<T> Sub(IMatrice<T> A, IMatrice<T> B);

		IMatrice<T> Transpose { get; }
		T Determinant {get; }
		IMatrice<T> Comatrice { get; }
		IMatrice<T> Mult(IMatrice<T> A, IMatrice<T> B);
		IMatrice<T> Mult(IMatrice<T> A,T n);
		IMatrice<T> Inverse { get; }
	}
}