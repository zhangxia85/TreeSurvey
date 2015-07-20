using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalProbabilityDistribution
{
	public abstract class SubSampleSet<T> where T : IMultidimensionalComparable<T>
	{
		public const int IndexTrigger = 1024;
		public const int IndexSegment = 16;
		public const int IndexLevel = 8;
		public enum Type
		{
			Index, Bucket
		}
		public abstract Type SubSampleSetType();
	}
	public class IndexSubSampleSet<T>:SubSampleSet<T> where T : IMultidimensionalComparable<T>
	{
		public IndexSubSampleSet(BucketSubSampleSet<T> bucketSubSampleSet)
		{
			throw new NotImplementedException();
		}
		public override Type SubSampleSetType()
		{ return SubSampleSet<T>.Type.Index; }
	}
	public class BucketSubSampleSet<T>:SubSampleSet<T> where T : IMultidimensionalComparable<T>
	{
		public override Type SubSampleSetType()
		{ return SubSampleSet<T>.Type.Bucket; }
		Dictionary<T,double> bucket = new Dictionary<T,double>(IndexTrigger);
		SubSampleSet<T> Add(T item,int num)
		{
			if (bucket.ContainsKey(item))
			{
				double temp = bucket[item] + num;
				bucket[item] = temp < 0 ? 0 : temp;
				return this;
			}
			if (bucket.Count == IndexTrigger)
				return new IndexSubSampleSet<T>(this);
			bucket.Add(item,num > 0 ? num : 1);
			return this;
		}
	}
	public class SampleSet<T> where T : IMultidimensionalComparable<T>
	{
		SubSampleSet<T> storage;
	}
}
