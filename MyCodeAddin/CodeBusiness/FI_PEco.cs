using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PEco))]
#if Dev
    [RunLocal]
#endif

	public class FI_PEco:ReadOnlyBase<FI_PEco>
    {
        #region Business Methods

		
        public string PEcoCode
        {
            get ;
            set ;
        }

		
        public string PEcoName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PEco Create()
        {
            return EF.DataPortal.Create<FI_PEco>();
        }

		public static FI_PEco Fetch(System.Linq.Expressions.Expression<Func<FI_PEco, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PEco>(exp,values);
            return EF.DataPortal.Fetch<FI_PEco>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PEcos))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PEcos:ReadOnlyListBase<FI_PEcos,FI_PEco>
    {
        #region Factory Methods

        public static FI_PEcos Fetch()
        {
            return EF.DataPortal.Fetch<FI_PEcos>();
        }

		public static FI_PEcos Fetch(System.Linq.Expressions.Expression<Func<FI_PEco, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PEco>(exp,values);
            return EF.DataPortal.Fetch<FI_PEcos>(lambda);
		}

		public static FI_PEcos Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PEcos>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PEcos Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PEco, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PEcos>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PEco>(exp,values)});
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
