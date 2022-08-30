namespace Domain
{
	using System.Collections.Generic;

	public class Size : Entity
	{
		public double PerfumeSize { get; set; }
		public int MeasurementUnitId { get; set; }

		public virtual MeasurementUnit MeasurementUnit { get; set; }
		public virtual ICollection<PerfumeSizes> Perfumes { get; set; } = new HashSet<PerfumeSizes>();
	}
}
