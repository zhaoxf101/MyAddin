using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_NRValue))]
#if Dev
    [RunLocal]
#endif

	public class EF_NRValue:ReadOnlyBase<EF_NRValue>
    {
        #region Business Methods

		
        public string NRArea
        {
            get ;
            set ;
        }

		
        public string NRObject
        {
            get ;
            set ;
        }

		
        public string YearPid
        {
            get ;
            set ;
        }

		
        public string RangeNR
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

		
        public bool ExternFlag
        {
            get ;
            set ;
        }

		
        public bool IsUsing
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_NRValue Create()
        {
            return EF.DataPortal.Create<EF_NRValue>();
        }

		public static EF_NRValue Fetch(System.Linq.Expressions.Expression<Func<EF_NRValue, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_NRValue>(exp,values);
            return EF.DataPortal.Fetch<EF_NRValue>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_NRValues))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_NRValues:ReadOnlyListBase<EF_NRValues,EF_NRValue>
    {
        #region Factory Methods

        public static EF_NRValues Fetch()
        {
            return EF.DataPortal.Fetch<EF_NRValues>();
        }

		public static EF_NRValues Fetch(System.Linq.Expressions.Expression<Func<EF_NRValue, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_NRValue>(exp,values);
            return EF.DataPortal.Fetch<EF_NRValues>(lambda);
		}

		public static EF_NRValues Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_NRValues>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_NRValues Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_NRValue, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_NRValues>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_NRValue>(exp,values)});
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
