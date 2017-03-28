using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(EF_BarPrefix))]
#if Dev
    [RunLocal]
#endif

	public class EF_BarPrefix:ReadOnlyBase<EF_BarPrefix>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string BarPrefix
        {
            get ;
            set ;
        }

		
        public string BarMark
        {
            get ;
            set ;
        }

		
        public bool IsWF
        {
            get ;
            set ;
        }

		
        public string WinformName
        {
            get ;
            set ;
        }

		
        public string WebformName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static EF_BarPrefix Create()
        {
            return EF.DataPortal.Create<EF_BarPrefix>();
        }

		public static EF_BarPrefix Fetch(System.Linq.Expressions.Expression<Func<EF_BarPrefix, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<EF_BarPrefix>(exp,values);
            return EF.DataPortal.Fetch<EF_BarPrefix>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(EF_BarPrefixs))]
#if Dev
    [RunLocal]
#endif
	
	public class EF_BarPrefixs:ReadOnlyListBase<EF_BarPrefixs,EF_BarPrefix>
    {
        #region Factory Methods

        public static EF_BarPrefixs Fetch()
        {
            return EF.DataPortal.Fetch<EF_BarPrefixs>();
        }

		public static EF_BarPrefixs Fetch(System.Linq.Expressions.Expression<Func<EF_BarPrefix, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<EF_BarPrefix>(exp,values);
            return EF.DataPortal.Fetch<EF_BarPrefixs>(lambda);
		}

		public static EF_BarPrefixs Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<EF_BarPrefixs>(new Paging { Page=page,RowCount=rowCount});
        }

        public static EF_BarPrefixs Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<EF_BarPrefix, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<EF_BarPrefixs>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<EF_BarPrefix>(exp,values)});
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
