using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_ExpTypeEco))]
#if Dev
    [RunLocal]
#endif

	public class FI_ExpTypeEco:ReadOnlyBase<FI_ExpTypeEco>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string ExpTypeCode
        {
            get ;
            set ;
        }

		
        public string PBudExpEcoCode
        {
            get ;
            set ;
        }

		
        public bool IsAuto
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_ExpTypeEco Create()
        {
            return EF.DataPortal.Create<FI_ExpTypeEco>();
        }

		public static FI_ExpTypeEco Fetch(System.Linq.Expressions.Expression<Func<FI_ExpTypeEco, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpTypeEco>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpTypeEco>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_ExpTypeEcos))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_ExpTypeEcos:ReadOnlyListBase<FI_ExpTypeEcos,FI_ExpTypeEco>
    {
        #region Factory Methods

        public static FI_ExpTypeEcos Fetch()
        {
            return EF.DataPortal.Fetch<FI_ExpTypeEcos>();
        }

		public static FI_ExpTypeEcos Fetch(System.Linq.Expressions.Expression<Func<FI_ExpTypeEco, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_ExpTypeEco>(exp,values);
            return EF.DataPortal.Fetch<FI_ExpTypeEcos>(lambda);
		}

		public static FI_ExpTypeEcos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_ExpTypeEcos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_ExpTypeEcos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_ExpTypeEco, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_ExpTypeEcos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_ExpTypeEco>(exp,values)});
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
