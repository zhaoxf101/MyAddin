using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_BarValue))]
#if Dev
    [RunLocal]
#endif

	public class EF_BarValue:ReadOnlyBase<EF_BarValue>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BarObject
        {
            get ;
            set ;
        }

		
        public string PrefixName
        {
            get ;
            set ;
        }

		
        public string FromNum
        {
            get ;
            set ;
        }

		
        public string ToNum
        {
            get ;
            set ;
        }

		
        public string CurrentNum
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_BarValue Create()
        {
            return EF.DataPortal.Create<EF_BarValue>();
        }

		public static EF_BarValue Fetch(System.Linq.Expressions.Expression<Func<EF_BarValue, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_BarValue>(exp,values);
            return EF.DataPortal.Fetch<EF_BarValue>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_BarValues))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_BarValues:ReadOnlyListBase<EF_BarValues,EF_BarValue>
    {
        #region Factory Methods

        public static EF_BarValues Fetch()
        {
            return EF.DataPortal.Fetch<EF_BarValues>();
        }

		public static EF_BarValues Fetch(System.Linq.Expressions.Expression<Func<EF_BarValue, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_BarValue>(exp,values);
            return EF.DataPortal.Fetch<EF_BarValues>(lambda);
		}

		public static EF_BarValues Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_BarValues>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_BarValues Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_BarValue, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_BarValues>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_BarValue>(exp,values)});
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
