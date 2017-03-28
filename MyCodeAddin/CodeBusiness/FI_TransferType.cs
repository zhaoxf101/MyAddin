using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(FI_TransferType))]
#if Dev
    [RunLocal]
#endif

	public class FI_TransferType:ReadOnlyBase<FI_TransferType>
    {
        #region Business Methods

		
        public string Client
        {
            get ;
            set ;
        }

		
        public string TransferTypeCode
        {
            get ;
            set ;
        }

		
        public string TransferTypeName
        {
            get ;
            set ;
        }

		
		#endregion

		#region Factory Methods

		public static FI_TransferType Create()
        {
            return EF.DataPortal.Create<FI_TransferType>();
        }

		public static FI_TransferType Fetch(System.Linq.Expressions.Expression<Func<FI_TransferType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<FI_TransferType>(exp,values);
            return EF.DataPortal.Fetch<FI_TransferType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(FI_TransferTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class FI_TransferTypes:ReadOnlyListBase<FI_TransferTypes,FI_TransferType>
    {
        #region Factory Methods

        public static FI_TransferTypes Fetch()
        {
            return EF.DataPortal.Fetch<FI_TransferTypes>();
        }

		public static FI_TransferTypes Fetch(System.Linq.Expressions.Expression<Func<FI_TransferType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<FI_TransferType>(exp,values);
            return EF.DataPortal.Fetch<FI_TransferTypes>(lambda);
		}

		public static FI_TransferTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<FI_TransferTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static FI_TransferTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<FI_TransferType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<FI_TransferTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<FI_TransferType>(exp,values)});
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
