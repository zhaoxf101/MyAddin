using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EF.Server;
using EF;

namespace Common.Business
{

	[Serializable]
    [CMFactory(typeof(PM_VoucherType))]
#if Dev
    [RunLocal]
#endif

	public class PM_VoucherType:ReadOnlyBase<PM_VoucherType>
    {
        #region Business Methods

		
        public string VouType
        {
            get ;
            set ;
        }

		
        public string PostRNR
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

		public static PM_VoucherType Create()
        {
            return EF.DataPortal.Create<PM_VoucherType>();
        }

		public static PM_VoucherType Fetch(System.Linq.Expressions.Expression<Func<PM_VoucherType, bool>> exp,params object[] values)
        {
			LambdaExpression lambda = LambdaExpression.Create<PM_VoucherType>(exp,values);
            return EF.DataPortal.Fetch<PM_VoucherType>(lambda);
        }

		#endregion

	}

	[Serializable]
    [CMFactory(typeof(PM_VoucherTypes))]
#if Dev
    [RunLocal]
#endif
	
	public class PM_VoucherTypes:ReadOnlyListBase<PM_VoucherTypes,PM_VoucherType>
    {
        #region Factory Methods

        public static PM_VoucherTypes Fetch()
        {
            return EF.DataPortal.Fetch<PM_VoucherTypes>();
        }

		public static PM_VoucherTypes Fetch(System.Linq.Expressions.Expression<Func<PM_VoucherType, bool>> exp,params object[] values)
		{
			LambdaExpression lambda = LambdaExpression.Create<PM_VoucherType>(exp,values);
            return EF.DataPortal.Fetch<PM_VoucherTypes>(lambda);
		}

		public static PM_VoucherTypes Fetch(int page, int rowCount)
        {
            return EF.DataPortal.Fetch<PM_VoucherTypes>(new Paging { Page=page,RowCount=rowCount});
        }

        public static PM_VoucherTypes Fetch(int page, int rowCount, System.Linq.Expressions.Expression<Func<PM_VoucherType, bool>> exp,params object[] values)
        {
            return EF.DataPortal.Fetch<PM_VoucherTypes>(new PagigExpress { Page=page,RowCount=rowCount,Lambda=LambdaExpression.Create<PM_VoucherType>(exp,values)});
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
