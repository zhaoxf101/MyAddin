using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_RemType))]
#if Dev
    [RunLocal]
#endif

	public class FI_RemType:ReadOnlyBase<FI_RemType>
    {
        #region Business Methods

		
        public string RemTypeCode
        {
            get ;
            set ;
        }

		
        public string RemTypeName
        {
            get ;
            set ;
        }

		
        public bool? IsBank
        {
            get ;
            set ;
        }

		
        public string Account
        {
            get ;
            set ;
        }

		
        public int? SortOrder
        {
            get ;
            set ;
        }

		
        public bool IsIn
        {
            get ;
            set ;
        }

		
        public bool IsZero
        {
            get ;
            set ;
        }

		
        public bool IsBankAcc
        {
            get ;
            set ;
        }

		
        public bool IsFundAcc
        {
            get ;
            set ;
        }

		
        public bool IsIncAcc
        {
            get ;
            set ;
        }

		
        public string PayType
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_RemType Create()
        {
            return EF.DataPortal.Create<FI_RemType>();
        }

		public static FI_RemType Fetch(System.Linq.Expressions.Expression<Func<FI_RemType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_RemType>(exp,values);
            return EF.DataPortal.Fetch<FI_RemType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_RemTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_RemTypes:ReadOnlyListBase<FI_RemTypes,FI_RemType>
    {
        #region Factory Methods

        public static FI_RemTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_RemTypes>();
        }

		public static FI_RemTypes Fetch(System.Linq.Expressions.Expression<Func<FI_RemType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_RemType>(exp,values);
            return EF.DataPortal.Fetch<FI_RemTypes>(lambda);
		}

		public static FI_RemTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_RemTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_RemTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_RemType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_RemTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_RemType>(exp,values)});
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
