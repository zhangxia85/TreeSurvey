using System;
using System.Collections;
using System.Collections.Generic;

namespace MultidimensionalProbabilityDistribution
{
	/// <summary>
	/// The interface for any type can be compared in seperate dimensions.
	/// </summary>
	public interface IMultidimensionalComparable<in T>
	{
		/// <summary>
		/// Compare this object with other in a multidimensional way.
		/// result[i] lt 0 means this[i] lt other[i];
		/// result[i] eq 0 means this[i] eq other[i];
		/// result[i] gt 0 means this[i] gt other[i].
		/// </summary>
		int[] MultidimensionalCompareTo(T other);
		/// <summary>
		/// The number of dimensions for comparing.
		/// </summary>
		int ComparableDimension();
	}
	/// <summary>
	/// The inferface for any comparer that compares two objects in seperate dimensions.
	/// </summary>
	public interface IMultidimensionalComparer<in T>
	{
		/// <summary>
		/// Compare two objects in a multidimensional way.
		/// result[i] lt 0 means x[i] lt y[i];
		/// result[i] eq 0 means x[i] eq y[i];
		/// result[i] gt 0 means x[i] gt y[i].
		/// </summary>
		int[] MultidimensionalCompare(T x,T y);
		/// <summary>
		/// The number of dimensions for comparing.
		/// </summary>
		int ComparableDimension();
	}
	public static class MultidimensionalComparable
	{
		public static int[] MultidimensionalCompareTo<T>(this IComparable<T> me,T other)
		{ return new int[] { me.CompareTo(other) }; }
		public static int ComparableDimension<T>(this IComparable<T> me)
		{ return 1; }
		public static int[] MultidimensionalCompareTo(this IComparable me,object other)
		{ return new int[] { me.CompareTo(other) }; }
		public static int ComparableDimension(this IComparable me)
		{ return 1; }
		public static int[] MultidimensionalCompare<T>(this IComparer<T> me,T x,T y)
		{ return new int[] { me.Compare(x,y) }; }
		public static int ComparableDimension<T>(this IComparer<T> me)
		{ return 1; }
		public static int[] MultidimensionalCompare(this IComparer me,object x,object y)
		{ return new int[] { me.Compare(x,y) }; }
		public static int ComparableDimension(this IComparer me)
		{ return 1; }
	}
}
