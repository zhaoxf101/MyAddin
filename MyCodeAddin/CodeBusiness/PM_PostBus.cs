using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_PostBus))]
#if Dev
    [RunLocal]
#endif

	public class PM_PostBus:ReadOnlyBase<PM_PostBus>
    {
        #region Business Methods

		
        public string PostBus
        {
            get ;
            set ;
        }

		
        public string PostMark
        {
            get ;
            set ;
        }

		
        public bool PostProj
        {
            get ;
            set ;
        }

		
        public bool PostFund
        {
            get ;
            set ;
        }

		
        public bool PostAss
        {
            get ;
            set ;
        }

		
        public bool PostCont
        {
            get ;
            set ;
        }

		
        public string Status
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static PM_PostBus Create()
        {
            return EF.DataPortal.Create<PM_PostBus>();
        }

		public static PM_PostBus Fetch(System.Linq.Expressions.Expression<Func<PM_PostBus, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_PostBus>(exp,values);
            return EF.DataPortal.Fetch<PM_PostBus>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_PostBuss))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_PostBuss:ReadOnlyListBase<PM_PostBuss,PM_PostBus>
    {
        #region Factory Methods

        public static PM_PostBuss Fetch()
        {
            return EF.DataPortal.Fetch<PM_PostBuss>();
        }

		public static PM_PostBuss Fetch(System.Linq.Expressions.Expression<Func<PM_PostBus, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_PostBus>(exp,values);
            return EF.DataPortal.Fetch<PM_PostBuss>(lambda);
		}

		public static PM_PostBuss Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_PostBuss>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_PostBuss Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_PostBus, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_PostBuss>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_PostBus>(exp,values)});
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
