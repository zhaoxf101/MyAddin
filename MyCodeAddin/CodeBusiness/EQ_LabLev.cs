using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EQ_LabLev))]
#if Dev
    [RunLocal]
#endif

	public class EQ_LabLev:ReadOnlyBase<EQ_LabLev>
    {
        #region Business Methods

		
        public string LabLevCode
        {
            get ;
            set ;
        }

		
        public string LabLevName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EQ_LabLev Create()
        {
            return EF.DataPortal.Create<EQ_LabLev>();
        }

		public static EQ_LabLev Fetch(System.Linq.Expressions.Expression<Func<EQ_LabLev, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EQ_LabLev>(exp,values);
            return EF.DataPortal.Fetch<EQ_LabLev>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EQ_LabLevs))]
#if Dev
    [RunLocal]
#endif
	
	public class EQ_LabLevs:ReadOnlyListBase<EQ_LabLevs,EQ_LabLev>
    {
        #region Factory Methods

        public static EQ_LabLevs Fetch()
        {
            return EF.DataPortal.Fetch<EQ_LabLevs>();
        }

		public static EQ_LabLevs Fetch(System.Linq.Expressions.Expression<Func<EQ_LabLev, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EQ_LabLev>(exp,values);
            return EF.DataPortal.Fetch<EQ_LabLevs>(lambda);
		}

		public static EQ_LabLevs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EQ_LabLevs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EQ_LabLevs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EQ_LabLev, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EQ_LabLevs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EQ_LabLev>(exp,values)});
        }

        #endregion

		[Serializable]
        public class Paging
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get 
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        [Serializable]
        public class PagigExpress
        {
            public int Page { get; set; }
            public int RowCount { get; set; }
            public int StartIndex
            {
                get
                {
                    if (Page >= 0 && RowCount > 0)
                    {
                        return Page * RowCount;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            public LambdaExpression Lambda { get; set; }
        }

    }
}
