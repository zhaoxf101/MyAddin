using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(TM_ExperEqu))]
#if Dev
    [RunLocal]
#endif

	public class TM_ExperEqu:ReadOnlyBase<TM_ExperEqu>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExperCode
        {
            get ;
            set ;
        }

		
        public string EquCode
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static TM_ExperEqu Create()
        {
            return EF.DataPortal.Create<TM_ExperEqu>();
        }

		public static TM_ExperEqu Fetch(System.Linq.Expressions.Expression<Func<TM_ExperEqu, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<TM_ExperEqu>(exp,values);
            return EF.DataPortal.Fetch<TM_ExperEqu>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(TM_ExperEqus))]
#if Dev
    [RunLocal]
#endif
	
	public class TM_ExperEqus:ReadOnlyListBase<TM_ExperEqus,TM_ExperEqu>
    {
        #region Factory Methods

        public static TM_ExperEqus Fetch()
        {
            return EF.DataPortal.Fetch<TM_ExperEqus>();
        }

		public static TM_ExperEqus Fetch(System.Linq.Expressions.Expression<Func<TM_ExperEqu, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<TM_ExperEqu>(exp,values);
            return EF.DataPortal.Fetch<TM_ExperEqus>(lambda);
		}

		public static TM_ExperEqus Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<TM_ExperEqus>(new Paging { Page=page,RowCount=rowCount});
        }

        public static TM_ExperEqus Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<TM_ExperEqu, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<TM_ExperEqus>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<TM_ExperEqu>(exp,values)});
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
