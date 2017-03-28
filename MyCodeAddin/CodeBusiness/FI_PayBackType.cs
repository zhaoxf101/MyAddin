using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_PayBackType))]
#if Dev
    [RunLocal]
#endif

	public class FI_PayBackType:ReadOnlyBase<FI_PayBackType>
    {
        #region Business Methods

		
        public string PayBackType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string GLMark
        {
            get ;
            set ;
        }

		
        public string AccType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_PayBackType Create()
        {
            return EF.DataPortal.Create<FI_PayBackType>();
        }

		public static FI_PayBackType Fetch(System.Linq.Expressions.Expression<Func<FI_PayBackType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_PayBackType>(exp,values);
            return EF.DataPortal.Fetch<FI_PayBackType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_PayBackTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_PayBackTypes:ReadOnlyListBase<FI_PayBackTypes,FI_PayBackType>
    {
        #region Factory Methods

        public static FI_PayBackTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_PayBackTypes>();
        }

		public static FI_PayBackTypes Fetch(System.Linq.Expressions.Expression<Func<FI_PayBackType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_PayBackType>(exp,values);
            return EF.DataPortal.Fetch<FI_PayBackTypes>(lambda);
		}

		public static FI_PayBackTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_PayBackTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_PayBackTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_PayBackType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_PayBackTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_PayBackType>(exp,values)});
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
