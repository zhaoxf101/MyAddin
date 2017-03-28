using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_FundUType))]
#if Dev
    [RunLocal]
#endif

	public class FI_FundUType:ReadOnlyBase<FI_FundUType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string FundUTypeCode
        {
            get ;
            set ;
        }

		
        public string FundUTypeName
        {
            get ;
            set ;
        }

		
        public bool Active
        {
            get ;
            set ;
        }

		
        public string CreatedUser
        {
            get ;
            set ;
        }

		
        public DateTime? CreatedDate
        {
            get ;
            set ;
        }

		
        public string ChangedUser
        {
            get ;
            set ;
        }

		
        public DateTime? ChangedDate
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_FundUType Create()
        {
            return EF.DataPortal.Create<FI_FundUType>();
        }

		public static FI_FundUType Fetch(System.Linq.Expressions.Expression<Func<FI_FundUType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_FundUType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundUType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_FundUTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_FundUTypes:ReadOnlyListBase<FI_FundUTypes,FI_FundUType>
    {
        #region Factory Methods

        public static FI_FundUTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_FundUTypes>();
        }

		public static FI_FundUTypes Fetch(System.Linq.Expressions.Expression<Func<FI_FundUType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_FundUType>(exp,values);
            return EF.DataPortal.Fetch<FI_FundUTypes>(lambda);
		}

		public static FI_FundUTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_FundUTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_FundUTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_FundUType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_FundUTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_FundUType>(exp,values)});
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
