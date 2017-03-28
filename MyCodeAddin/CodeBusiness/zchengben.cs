using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(zchengben))]
#if Dev
    [RunLocal]
#endif

	public class zchengben:ReadOnlyBase<zchengben>
    {
        #region Business Methods

		
        public string CostArea
        {
            get ;
            set ;
        }

		
        public string CostCtr
        {
            get ;
            set ;
        }

		
        public string CostCtrType
        {
            get ;
            set ;
        }

		
        public string Leader
        {
            get ;
            set ;
        }

		
        public string ProfitCtr
        {
            get ;
            set ;
        }

		
        public string DepCode
        {
            get ;
            set ;
        }

		
        public string SText
        {
            get ;
            set ;
        }

		
        public string LText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static zchengben Create()
        {
            return EF.DataPortal.Create<zchengben>();
        }

		public static zchengben Fetch(System.Linq.Expressions.Expression<Func<zchengben, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<zchengben>(exp,values);
            return EF.DataPortal.Fetch<zchengben>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(zchengbens))]
#if Dev
    [RunLocal]
#endif
	
	public class zchengbens:ReadOnlyListBase<zchengbens,zchengben>
    {
        #region Factory Methods

        public static zchengbens Fetch()
        {
            return EF.DataPortal.Fetch<zchengbens>();
        }

		public static zchengbens Fetch(System.Linq.Expressions.Expression<Func<zchengben, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<zchengben>(exp,values);
            return EF.DataPortal.Fetch<zchengbens>(lambda);
		}

		public static zchengbens Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<zchengbens>(new Paging { Page=page,RowCount=rowCount});
        }

        public static zchengbens Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<zchengben, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<zchengbens>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<zchengben>(exp,values)});
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
