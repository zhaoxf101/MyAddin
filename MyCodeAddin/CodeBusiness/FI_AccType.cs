using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_AccType))]
#if Dev
    [RunLocal]
#endif

	public class FI_AccType:ReadOnlyBase<FI_AccType>
    {
        #region Business Methods

		
        public string AccType
        {
            get ;
            set ;
        }

		
        public string DText
        {
            get ;
            set ;
        }

		
        public string VouType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_AccType Create()
        {
            return EF.DataPortal.Create<FI_AccType>();
        }

		public static FI_AccType Fetch(System.Linq.Expressions.Expression<Func<FI_AccType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_AccType>(exp,values);
            return EF.DataPortal.Fetch<FI_AccType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_AccTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_AccTypes:ReadOnlyListBase<FI_AccTypes,FI_AccType>
    {
        #region Factory Methods

        public static FI_AccTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_AccTypes>();
        }

		public static FI_AccTypes Fetch(System.Linq.Expressions.Expression<Func<FI_AccType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_AccType>(exp,values);
            return EF.DataPortal.Fetch<FI_AccTypes>(lambda);
		}

		public static FI_AccTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_AccTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_AccTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_AccType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_AccTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_AccType>(exp,values)});
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
